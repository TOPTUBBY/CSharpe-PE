#include <SoftwareSerial.h>
#define rxPin 3
#define txPin 4
#define SW_INPUTPIN 2
bool button_status ;
bool button_status_1;
int count;
int count_1;
int count_1_interrupt;
String c = "";
String d = "";
String command = "";
unsigned long previousMillis = 0;
const long interval = 10000;

SoftwareSerial serial1 = SoftwareSerial(rxPin, txPin);

void setup() {
  // put your setup code here, to run once:
  pinMode(rxPin, INPUT);
  pinMode(txPin, OUTPUT);
  pinMode(SW_INPUTPIN, INPUT_PULLUP);
  Serial.begin(9600);
  serial1.begin(9600);

}

//Serial is GUI
//Serial1 (for Mega) is Ext.Equipment
//serial1 (for Uno) is Ext.Equipment
void loop() {
  //interrupt 10 sec DC off
  unsigned long currentMillis = millis();
  if  (count_1_interrupt == 1 && (currentMillis - previousMillis >= interval)) {
    Serial.println("0");
    serial1.println("CONFigure:OUTPut OFF");
    delay(100);
    serial1.println("CONFigure:OUTPut OFF");
    count_1 = 0;
    count = 0;
    previousMillis = currentMillis;
  }

  //ON-OFF(Foot button)---------------------------------
  int SW_INPUT = digitalRead(SW_INPUTPIN);
  if (SW_INPUT == LOW) {
    while (button_status < 1) {
      delay(200);
      button_status++;
      button_status_1 = 0;
      count++;
      count_1 = count;
    }
  }
  else {
    while (button_status_1 < 1) {
      delay(200);
      button_status = 0;
      button_status_1++;
    }
  }
  if (count_1 == 1) {
    count_1_interrupt = 1;
    Serial.println("1");
    serial1.println("CONFigure:OUTPut ON");
    delay(100);
    serial1.println("CONFigure:OUTPut ON");
    count_1 = 0;
  }

  else if (count_1 == 2) {
    Serial.println("0");
    serial1.println("CONFigure:OUTPut OFF");
    delay(100);
    serial1.println("CONFigure:OUTPut OFF");
    count_1 = 0;
    count = 0;
    previousMillis = currentMillis;
  }
  //ON-OFF(GUI)---------------------------------
  if (Serial.available() > 0) {
    c = Serial.readString();
    if (c == "1") {
      serial1.println("CONFigure:OUTPut ON");
      Serial.println("ON");
      delay(100);
      serial1.println("CONFigure:OUTPut ON");
    } else if (c == "0") {
      serial1.println("CONFigure:OUTPut OFF");
      delay(100);
      serial1.println("CONFigure:OUTPut OFF");
    } else {
      //Set point------------------------------
      String setType = c.substring(0, 1);
      String setValue = c.substring(2, 5);  //recieve max 999
      if (setType == "v") {
        serial1.println("sour:volt " + setValue);
        delay(500);
      } else if (setType == "a") {
        serial1.println("SOURce:CURRent " + setValue);
        delay(500);
      }
      //send to DC directly--------------------
      serial1.println(c);
      d = serial1.readString();
      //delay(500);
      Serial.println(d);
      serial1.println("*cls");

    }
  }

}
