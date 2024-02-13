//Correcte!! Chippi
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
bool gt=false;
bool red=false;

void setup() {
  Serial.begin(9600); // abre el puerto serie, configura los datos a 9600 bps
}

void loop() {
  // Starting Lights
  if (Serial.available() > 0) {
    char incomingByte = Serial.read();
    if(incomingByte=='a'){ // Starting lights Procedure light 1
      digitalWrite(lights1, HIGH);
      }
    if(incomingByte=='b'){ // Starting lights Procedure lights 1,2
      digitalWrite(lights2, HIGH);
      }
    if(incomingByte=='c'){ // Starting lights Procedure lights 1,2,3
      digitalWrite(lights3, HIGH);
      }
    if(incomingByte=='d'){ // Starting lights Procedure lights 1,2,3,4
      digitalWrite(lights4, HIGH);
      }
    if(incomingByte=='e'){ // Starting lights Procedure lights 1,2,3,4,5
      digitalWrite(lights5, HIGH);
      }
    if(incomingByte=='f'){ // Starting lights Procedure lights 1,2,3,4,5
      digitalWrite(lights1, LOW);
      digitalWrite(lights2, LOW);
      digitalWrite(lights3, LOW);
      digitalWrite(lights4, LOW);
      digitalWrite(lights5, LOW);
      }
    // Yellow Flags
    if(incomingByte=='g'){
      if(s1==true){
        digitalWrite(sector1R, HIGH);
        digitalWrite(sector1G, HIGH);
        s1=false;
        }else{
        digitalWrite(sector1R, LOW);
        digitalWrite(sector1G, LOW);
        s1=true;
        }
    }
    if(incomingByte=='h'){
    if(s2==true){
        digitalWrite(sector2R, HIGH);
        digitalWrite(sector2G, HIGH);
        s2=false;
        }else{
        digitalWrite(sector2R, LOW);
        digitalWrite(sector2G, LOW);
        s2=true;
        }
    }
    if(incomingByte=='i'){
    if(s3==true){
        digitalWrite(sector3R, HIGH);
        digitalWrite(sector3G, HIGH);
        s3=false;
        }else{
        digitalWrite(sector3R, LOW);
        digitalWrite(sector3G, LOW);
        s3=true;
        }
    }
    if(incomingByte=='j'){
    if(s4==true){
        digitalWrite(sector4R, HIGH);
        digitalWrite(sector4G, HIGH);
        s4=false;
        }else{
        digitalWrite(sector4R, LOW);
        digitalWrite(sector4G, LOW);
        s4=true;
        }
    }
    if(incomingByte=='k'){
    if(s5==true){
        digitalWrite(sector5R, HIGH);
        digitalWrite(sector5G, HIGH);
        s5=false;
        }else{
        digitalWrite(sector5R, LOW);
        digitalWrite(sector5G, LOW);
        s5=true;
        }
    }
    if(incomingByte=='l'){
    if(s6==true){
        digitalWrite(sector6R, HIGH);
        digitalWrite(sector6G, HIGH);
        s6=false;
        }else{
        digitalWrite(sector6R, LOW);
        digitalWrite(sector6G, LOW);
        s6=true;
        }
    }
    if(incomingByte=='m'){
    if(s7==true){
        digitalWrite(sector7R, HIGH);
        digitalWrite(sector7G, HIGH);
        s7=false;
        }else{
        digitalWrite(sector7R, LOW);
        digitalWrite(sector7G, LOW);
        s7=true;
        }
    }
    if(incomingByte=='n'){
    if(s8==true){
        digitalWrite(sector8R, HIGH);
        digitalWrite(sector8G, HIGH);
        s8=false;
        }else{
        digitalWrite(sector8R, LOW);
        digitalWrite(sector8G, LOW);
        s8=true;
        }
    }
    if(incomingByte=='o'){
    if(s9==true){
        digitalWrite(sector9R, HIGH);
        digitalWrite(sector9G, HIGH);
        s9=false;
        }else{
        digitalWrite(sector9R, LOW);
        digitalWrite(sector9G, LOW);
        s9=true;
        }
    }
    if(incomingByte=='p'){
    if(s10==true){
        digitalWrite(sector10R, HIGH);
        digitalWrite(sector10G, HIGH);
        s10=false;
        }else{
        digitalWrite(sector10R, LOW);
        digitalWrite(sector10G, LOW);
        s10=true;
        }
    }
    if(incomingByte=='z'){
    digitalWrite(sector1R, LOW);
    digitalWrite(sector1B, LOW);
    digitalWrite(sector2R, LOW);
    digitalWrite(sector2B, LOW);
    digitalWrite(sector3R, LOW);
    digitalWrite(sector3B, LOW);
    digitalWrite(sector4R, LOW);
    digitalWrite(sector4B, LOW);
    digitalWrite(sector5R, LOW);
    digitalWrite(sector5B, LOW);
    digitalWrite(sector6R, LOW);
    digitalWrite(sector6B, LOW);
    digitalWrite(sector7R, LOW);
    digitalWrite(sector7B, LOW);
    digitalWrite(sector8R, LOW);
    digitalWrite(sector8B, LOW);
    digitalWrite(sector9R, LOW);
    digitalWrite(sector9B, LOW);
    digitalWrite(sector10R, LOW);
    digitalWrite(sector10B, LOW);
    if(gt==true){
      digitalWrite(sector1G, LOW);
      digitalWrite(sector2G, LOW);
      digitalWrite(sector3G, LOW);
      digitalWrite(sector4G, LOW);
      digitalWrite(sector5G, LOW);
      digitalWrite(sector6G, LOW);
      digitalWrite(sector7G, LOW);
      digitalWrite(sector8G, LOW);
      digitalWrite(sector9G, LOW);
      digitalWrite(sector10G, LOW);
      gt=false;
    }else{
      digitalWrite(sector1G, HIGH);
      digitalWrite(sector2G, HIGH);
      digitalWrite(sector3G, HIGH);
      digitalWrite(sector4G, HIGH);
      digitalWrite(sector5G, HIGH);
      digitalWrite(sector6G, HIGH);
      digitalWrite(sector7G, HIGH);
      digitalWrite(sector8G, HIGH);
      digitalWrite(sector9G, HIGH);
      digitalWrite(sector10G, HIGH);
      gt=true;
    }
    }
    if(incomingByte=='w'){
    digitalWrite(sector1R, LOW);
    digitalWrite(sector1B, LOW);
    digitalWrite(sector2R, LOW);
    digitalWrite(sector2B, LOW);
    digitalWrite(sector3R, LOW);
    digitalWrite(sector3B, LOW);
    digitalWrite(sector4R, LOW);
    digitalWrite(sector4B, LOW);
    digitalWrite(sector5R, LOW);
    digitalWrite(sector5B, LOW);
    digitalWrite(sector6R, LOW);
    digitalWrite(sector6B, LOW);
    digitalWrite(sector7R, LOW);
    digitalWrite(sector7B, LOW);
    digitalWrite(sector8R, LOW);
    digitalWrite(sector8B, LOW);
    digitalWrite(sector9R, LOW);
    digitalWrite(sector9B, LOW);
    digitalWrite(sector10R, LOW);
    digitalWrite(sector10B, LOW);
    if(red==true){
      digitalWrite(sector1G, LOW);
      digitalWrite(sector2G, LOW);
      digitalWrite(sector3G, LOW);
      digitalWrite(sector4G, LOW);
      digitalWrite(sector5G, LOW);
      digitalWrite(sector6G, LOW);
      digitalWrite(sector7G, LOW);
      digitalWrite(sector8G, LOW);
      digitalWrite(sector9G, LOW);
      digitalWrite(sector10G, LOW);
      red=false;
    }else{
      digitalWrite(sector1G, HIGH);
      digitalWrite(sector2G, HIGH);
      digitalWrite(sector3G, HIGH);
      digitalWrite(sector4G, HIGH);
      digitalWrite(sector5G, HIGH);
      digitalWrite(sector6G, HIGH);
      digitalWrite(sector7G, HIGH);
      digitalWrite(sector8G, HIGH);
      digitalWrite(sector9G, HIGH);
      digitalWrite(sector10G, HIGH);
      red=true;
    }
    }
  }
}
