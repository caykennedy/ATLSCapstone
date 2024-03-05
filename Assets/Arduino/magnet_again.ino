//For more Projects: www.arduinocircuit.com
const int HALLPin = 2;
const int LEDPin = 13;
int sensorPin = A0; 
void setup() {
  Serial.begin(9600);
//  //pinMode(LEDPin, OUTPUT);
//  pinMode(HALLPin, INPUT);

}
void loop() {
  int sensorValue = analogRead(sensorPin);
  Serial.println(sensorValue);
  if(sensorValue <= 1012){
    Serial.println("A wild Magnet has appeared");
  }else{
       Serial.println("No Magnet :(");
  }
//  if(digitalRead(HALLPin)==LOW){
//  Serial.println("No Magnet :(");
//  
//    //digitalWrite(LEDPin, HIGH);
//  }
//  else
//  {
//    Serial.println("Magnet :)");
//  }
    delay(500);
}
