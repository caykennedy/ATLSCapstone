int buttonPin= 3;
void setup()
{
  Serial.begin(9600);
  pinMode(buttonPin, INPUT_PULLUP);
}
void loop()
{
  int buttonState = digitalRead(buttonPin);
  
  if (buttonState == HIGH) {
      Serial.println("Button is not pressed");
  }
  else {
      Serial.println("Button is pressed");
  }
  delay(500);
}
