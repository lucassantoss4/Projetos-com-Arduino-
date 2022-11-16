// Declaracao de variaveis
int adc;
float tensao;
float temp;
float aLM35 = 100;  // coef. angular do LM35
float bLM35 = 0;    // coef. linear do LM35

void setup() {
  Serial.begin(9600);   // inicia a serial com baud rate de 9600 bits/s
  analogReference(INTERNAL); // Conversao A/D com fundo de escala de 1.1V
}
void loop() {
  adc = analogRead(A0);       //Le a entrada analogica A0
  tensao = adc*(1.1/1024);    // converte em tensao
  temp = tensao*aLM35 + bLM35;// converte em temperatura (oC)
  Serial.print("Dado bruto(0-1023): ");
  Serial.println(adc);
  Serial.print("Tensao(V): ");
  Serial.println(tensao,4); // mostra com 4 casas decimais
  Serial.print("Temperatura(oC): ");
  Serial.println(temp,4); // mostra com 4 casas decimais
  Serial.print("\n");
  Serial.println("*************************");
  Serial.print("\n");
  // Aguarda dois segundos
  delay(2000);
}