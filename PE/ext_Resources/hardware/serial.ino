#include <SoftwareSerial.h>

#define rxPin 3
#define txPin 4
#define SW_INPUTPIN 2

const unsigned long OUTPUT_TIMEOUT_MS = 30000UL;
const unsigned long DEBOUNCE_MS = 50UL;

SoftwareSerial serial1(rxPin, txPin);

bool outputOn = false;
bool buttonState = HIGH;
bool lastButtonReading = HIGH;
unsigned long outputOnStartedAt = 0;
unsigned long lastDebounceAt = 0;

void setOutput(bool turnOn) {
  outputOn = turnOn;

  if (turnOn) {
    outputOnStartedAt = millis();
    serial1.println("CONFigure:OUTPut ON");
    delay(100);
    serial1.println("CONFigure:OUTPut ON");
    Serial.println("1");
  } else {
    serial1.println("CONFigure:OUTPut OFF");
    delay(100);
    serial1.println("CONFigure:OUTPut OFF");
    Serial.println("0");
  }
}

void handleFootButton(unsigned long currentMillis) {
  bool reading = digitalRead(SW_INPUTPIN);

  if (reading != lastButtonReading) {
    lastDebounceAt = currentMillis;
  }

  if ((currentMillis - lastDebounceAt) >= DEBOUNCE_MS && reading != buttonState) {
    buttonState = reading;

    if (buttonState == LOW) {
      setOutput(!outputOn);
    }
  }

  lastButtonReading = reading;
}

void forwardEquipmentResponse() {
  if (serial1.available() > 0) {
    String response = serial1.readString();
    response.trim();

    if (response.length() > 0) {
      Serial.println(response);
    }
  }
}

void handleGuiCommand() {
  if (Serial.available() <= 0) {
    return;
  }

  String command = Serial.readString();
  command.trim();

  if (command.length() == 0) {
    return;
  }

  if (command == "1") {
    setOutput(true);
    return;
  }

  if (command == "0") {
    setOutput(false);
    return;
  }

  int separatorIndex = command.indexOf(',');
  if (separatorIndex > 0) {
    String setType = command.substring(0, separatorIndex);
    String setValue = command.substring(separatorIndex + 1);
    setType.trim();
    setValue.trim();

    if (setValue.length() == 0) {
      Serial.println("ERR:EMPTY_SETPOINT");
      return;
    }

    if (setType == "v") {
      serial1.println("SOURce:VOLTage " + setValue);
      delay(100);
      serial1.println("*cls");
      forwardEquipmentResponse();
      return;
    }

    if (setType == "a") {
      serial1.println("SOURce:CURRent " + setValue);
      delay(100);
      serial1.println("*cls");
      forwardEquipmentResponse();
      return;
    }
  }

  // Forward supported SCPI commands entered from the manual command box.
  serial1.println(command);
  delay(100);
  forwardEquipmentResponse();
}

void setup() {
  pinMode(rxPin, INPUT);
  pinMode(txPin, OUTPUT);
  pinMode(SW_INPUTPIN, INPUT_PULLUP);

  Serial.begin(9600);
  Serial.setTimeout(100);
  serial1.begin(9600);
  serial1.setTimeout(250);
}

void loop() {
  unsigned long currentMillis = millis();

  handleFootButton(currentMillis);
  handleGuiCommand();

  if (outputOn && (currentMillis - outputOnStartedAt >= OUTPUT_TIMEOUT_MS)) {
    setOutput(false);
  }
}
