// Sources: 
//For more Projects: www.arduinocircuit.com

// Wood Choice Options
int buttonPin1 = 3; // Fairy Town
int buttonPin2 = 4; // Path of Wisps

// Crystal Cave Scene
const int HALLPin = 2;
const int LEDPin = 13;
int sensorPin = A0; 
void setup()
{
  Serial.begin(9600);
  pinMode(buttonPin1, INPUT_PULLUP);
  pinMode(buttonPin2, INPUT_PULLUP);
  pinMode(sensorPin, INPUT);
}
void loop()
{
  WoodChoices();
  CrystalCave();
}

void WoodChoices()
{
  int buttonState1 = digitalRead(buttonPin1);
  int buttonState2 = digitalRead(buttonPin2);

  //pin 3
  if (buttonState1 == LOW) {
      Serial.println("Fairy Town is pressed");
  }
  //pin 4
  if (buttonState2 == LOW) {
      Serial.println("Path of Wisps is pressed");
  }
  else {
      Serial.println("Buttons are not pressed");
  }
  delay(500);
}

void CrystalCave()
{
  int sensorValue = analogRead(sensorPin);
  Serial.println(sensorValue);
  if(sensorValue <= 1012){
    Serial.println("A wild Magnet has appeared");
  }else{
       Serial.println("No Magnet :(");
  }
  delay(500);
}
