bool botao;

void setup() {
  // put your setup code here, to run once:
  pinMode(11, OUTPUT); // Configura o pino especificado para funcionar como uma entrada.
  pinMode(2,INPUT); //Configura o pino especificado para funcionar como uma saida.


}

void loop() {
  // put your main code here, to run repeatedly:

  // acende quando o botao é presionado 
  
 botao =  digitalRead(2);
 if ( botao == true){
  digitalWrite(11,true);
 }
  // apaga quando estiver solto
if ( botao == false){
  digitalWrite(11,false);
 }
}