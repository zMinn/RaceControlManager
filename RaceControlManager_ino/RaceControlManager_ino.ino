int incomingByte = 0;
const int lights1 = 49;  
const int lights2 = 50;  
const int lights3 = 51;  
const int lights4 = 52;  
const int lights5 = 53;  

const int sector1R = 53;
const int sector1G = 53;
const int sector1B = 53;

const int sector2R = 53;
const int sector2G = 53;
const int sector2B = 53;

const int sector3R = 53;
const int sector3G = 53;
const int sector3B = 53;

const int sector4R = 53;
const int sector4G = 53;
const int sector4B = 53;

const int sector5R = 53;
const int sector5G = 53;
const int sector5B = 53;

const int sector6R = 53;
const int sector6G = 53;
const int sector6B = 53;

const int sector7R = 53;
const int sector7G = 53;
const int sector7B = 53;

const int sector8R = 53;
const int sector8G = 53;
const int sector8B = 53;

const int sector9R = 53;
const int sector9G = 53;
const int sector9B = 53;

const int sector10R = 53;
const int sector10G = 53;
const int sector10B = 53;


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
      digitalWrite(lights1, HIGH)
      }
    if(incomingByte=66){ // Starting lights Procedure lights 1,2
      digitalWrite(lights1, HIGH)
      }
    if(incomingByte=67){ // Starting lights Procedure lights 1,2,3
      digitalWrite(lights1, HIGH)
      }
    if(incomingByte=68){ // Starting lights Procedure lights 1,2,3,4
      digitalWrite(lights1, HIGH)
      }
    if(incomingByte=69){ // Starting lights Procedure lights 1,2,3,4,5
      digitalWrite(lights1, HIGH)
      }
    if(incomingByte=70){ // Starting lights Procedure lights off
      digitalWrite(lights1, LOW)
      digitalWrite(lights2, LOW)
      digitalWrite(lights3, LOW)
      digitalWrite(lights4, LOW)
      digitalWrite(lights5, LOW)


    // Sector1 
      }
    
  }
}
