// Sources: 
//For more Projects: www.arduinocircuit.com
//go faster or slower
int branchPin = 5;

// Wood Choice Options
int buttonPin1 = 3; // Fairy Town
int buttonPin2 = 4; // Path of Wisps

// Crystal Cave Scene
const int HALLPin = 2;
const int LEDPin = 13;
int magSensorPin = A0; 

//Enchanted Woods Scene
int lanternPin = 6;

void setup()
{
  Serial.begin(9600);
  pinMode(buttonPin1, INPUT_PULLUP);
  pinMode(buttonPin2, INPUT_PULLUP);
  pinMode(magSensorPin, INPUT);
  pinMode(lanternPin, INPUT);
  pinMode(branchPin, INPUT_PULLUP);
}
void loop()
{
  WoodChoices();
  CrystalCave();
  enchantedWoods();
  speedControl();
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
  int sensorValue = analogRead(magSensorPin);
  Serial.println(sensorValue);
  if(sensorValue >= 1010){
    Serial.println("No Magnet :(");
  }else{
       Serial.println("A wild Magnet has appeared");
  }
  delay(500);
}

void enchantedWoods()
{
  int touchVal = digitalRead(lanternPin);
  if (touchVal == LOW){
    Serial.println("No lantern!");
  }
  else{
    Serial.println("Lantern be sitting.");
  }
  delay(500);
}

void speedControl()
{
  int leverVal = digitalRead(branchPin);
  if (leverVal == LOW)
  {
    Serial.println("Slow!");
  }
  else
  {
    Serial.println("Fast!");
  }
  delay(500);
}
