int incomingByte = 0;
const int lights1 = 2;  
const int lights2 = 3;  
const int lights3 = 4;  
const int lights4 = 5;  
const int lights5 = 6;

const int sector1R = 53;
const int sector1G = 52;
const int sector1B = 51;

const int sector2R = 50;
const int sector2G = 49;
const int sector2B = 48;

const int sector3R = 47;
const int sector3G = 46;
const int sector3B = 45;

const int sector4R = 44;
const int sector4G = 43;
const int sector4B = 42;

const int sector5R = 41;
const int sector5G = 40;
const int sector5B = 39;

const int sector6R = 38;
const int sector6G = 37;
const int sector6B = 36;

const int sector7R = 35;
const int sector7G = 34;
const int sector7B = 33;

const int sector8R = 32;
const int sector8G = 31;
const int sector8B = 30;

const int sector9R = 29;
const int sector9G = 28;
const int sector9B = 27;

const int sector10R = 26;
const int sector10G = 25;
const int sector10B = 24;

bool s1=false;
bool s2=false;
bool s3=false;
bool s4=false;
bool s5=false;
bool s6=false;
bool s7=false;
bool s8=false;
bool s9=false;
bool s10=false;


void setup() {
  Serial.begin(9600); // abre el puerto serie, configura los datos a 9600 bps
}

void loop() {
  // Starting Lights
  if (Serial.available() > 0) {
    // lee el byte de entrada:
    incomingByte = Serial.read();
    // Starting
    if(incomingByte=65){ // Starting lights Procedure light 1
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=66){ // Starting lights Procedure lights 1,2
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=67){ // Starting lights Procedure lights 1,2,3
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=68){ // Starting lights Procedure lights 1,2,3,4
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=69){ // Starting lights Procedure lights 1,2,3,4,5
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=70){ // Starting lights Procedure lights off
      digitalWrite(lights1, LOW);
      digitalWrite(lights2, LOW);
      digitalWrite(lights3, LOW);
      digitalWrite(lights4, LOW);
      digitalWrite(lights5, LOW);
    }
    
    // Yellow Flags
    if(incomingByte=71){ // Sector1 Yellow Flag
      if(s1==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s1=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s1= true;
        }
      }
    if(incomingByte=72){ // Sector1 Yellow Flag
      if(s2==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s2=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s2= true;
        }
      }
    if(incomingByte=73){ // Sector1 Yellow Flag
      if(s3==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s3=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s3= true;
        }
      }
    if(incomingByte=74){ // Sector1 Yellow Flag
      if(s4==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s4=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s4= true;
        }
      }
    if(incomingByte=75){ // Sector1 Yellow Flag
      if(s5==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s5=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s5= true;
        }
      }
    if(incomingByte=76){ // Sector1 Yellow Flag
      if(s6==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s6=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s6= true;
        }
      }
    if(incomingByte=77){ // Sector1 Yellow Flag
      if(s7==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s7=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s7= true;
        }
      }
    if(incomingByte=78){ // Sector1 Yellow Flag
      if(s8==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s8=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s8= true;
        }
      }
    if(incomingByte=79){ // Sector1 Yellow Flag
      if(s9==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s9=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s9= true;
        }
      }
    if(incomingByte=80){ // Sector1 Yellow Flag
      if(s10==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s10=false;
      }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s10= true;
        }
      }             
    
  }
  
}
