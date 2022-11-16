#include <Adafruit_Sensor.h>
#include <DHT.h>
// Cria um objeto do tipo DHT utilizando
// o pino 2
DHT dht(2, DHT22);
float umid, temp;
void setup() {
  Serial.begin(9600);
  dht.begin();
}
void loop() {
  umid = dht.readHumidity();
  temp = dht.readTemperature();
  Serial.print("Umidade (%)= ");
  Serial.println(umid);
  Serial.print("Temperatura (oC) = ");
  Serial.println(temp);
  Serial.print("\n");
  delay(1000);
}