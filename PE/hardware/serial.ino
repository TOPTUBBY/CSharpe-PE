#define SW_INPUTPIN 2
bool button_status ;
bool button_status_1;
int count;
int count_1;
String c = "";

void setup() {
  // put your setup code here, to run once:
  pinMode(SW_INPUTPIN, INPUT_PULLUP);
  Serial.begin(115200);
  Serial1.begin(115200);

}
void loop() {
  //ON-OFF---------------------------------
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
    Serial.println("1");
    Serial1.println("CONFigure:OUTPut ON");
    delay(100);
    Serial1.println("CONFigure:OUTPut ON");
    count_1 = 0;
  }
  else if (count_1 == 2) {
    Serial.println("0");
    Serial1.println("CONFigure:OUTPut OFF");
    delay(100);
    Serial1.println("CONFigure:OUTPut OFF");
    count_1 = 0;
    count = 0;
  }
  //-------------------------------------------
  if (Serial.available() > 0) {
    c = Serial.readString();
    String setType = c.substring(0, 1);
    String setValue = c.substring(2, 5);
    if (setType == "v") {
      Serial1.println("SOURce:VOLTage " + setValue);
    } else if (setType == "a") {
      Serial1.println("SOURce:CURRent " + setValue);
    }
  }
}
