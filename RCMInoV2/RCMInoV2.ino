//Correcte!! Chippi
#include <Adafruit_NeoPixel.h>

#define PIN 12
#define NUMPIXELS 15
Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUMPIXELS, PIN, NEO_GRB + NEO_KHZ800);

int incomingByte = 0;

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
bool sc=false;
bool red=false;

void setup() {
  Serial.begin(9600); // abre el puerto serie, configura los datos a 9600 bps
  pixels.begin(); 

}

void loop() {
   uint32_t green = pixels.Color(0,150,0);
   uint32_t yellow = pixels.Color(255,150,0);
   uint32_t red = pixels.Color(150,0,0);
   uint32_t blue = pixels.Color(0,133,255);
  // Starting Lights
  if (Serial.available() > 0) {
    char incomingByte = Serial.read();
    if(incomingByte=='y'){ // All off
        for(int i=0;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Brillo moderado en rojo
    pixels.show();   // Mostramos y actualizamos el color del pixel de nuestra cinta led RGB
  }
      }
    if(incomingByte=='a'){ // Starting lights Procedure light 1
      pixels.setPixelColor(0, red);
      pixels.show(); 
      }
    if(incomingByte=='b'){ // Starting lights Procedure lights 1,2
      pixels.setPixelColor(1, red);
      pixels.show(); 
      }
    if(incomingByte=='c'){ // Starting lights Procedure lights 1,2,3
      pixels.setPixelColor(2, red);
      pixels.show(); 
      }
    if(incomingByte=='d'){ // Starting lights Procedure lights 1,2,3,4
      pixels.setPixelColor(3, red);
      pixels.show(); 
      }
    if(incomingByte=='e'){ // Starting lights Procedure lights 1,2,3,4,5
      pixels.setPixelColor(4, red);
      pixels.show(); 
      }
    if(incomingByte=='f'){ // Starting lights Procedure lights off
      pixels.setPixelColor(0, 0,0,0);
      pixels.setPixelColor(1, 0,0,0);
      pixels.setPixelColor(2, 0,0,0);
      pixels.setPixelColor(3, 0,0,0);
      pixels.setPixelColor(4, 0,0,0);
      pixels.show(); 
      }
    // Yellow Flags
    if(incomingByte=='g'){
      if(s1==true){
        pixels.setPixelColor(5, yellow);
        pixels.show(); 
        s1=false;
        }else{
        pixels.setPixelColor(5, 0,0,0);
        pixels.show(); 
        s1=true;
        }
    }
    if(incomingByte=='h'){
    if(s2==true){
        pixels.setPixelColor(6, yellow);
        pixels.show(); 
        s2=false;
        }else{
        pixels.setPixelColor(6, 0,0,0);
        pixels.show(); 
        s2=true;
        }
    }
    if(incomingByte=='i'){
    if(s3==true){
        pixels.setPixelColor(7, yellow);
        pixels.show(); 
        s3=false;
        }else{
        pixels.setPixelColor(7, 0,0,0);
        pixels.show(); 
        s3=true;
        }
    }
    if(incomingByte=='j'){
    if(s4==true){
        pixels.setPixelColor(8, yellow);
        pixels.show(); 
        s4=false;
        }else{
        pixels.setPixelColor(8, 0,0,0);
        pixels.show(); 
        s4=true;
        }
    }
    if(incomingByte=='k'){
    if(s5==true){
        pixels.setPixelColor(9, yellow);
        pixels.show(); 
        s5=false;
        }else{
        pixels.setPixelColor(9, 0,0,0);
        pixels.show(); 
        s5=true;
        }
    }
    if(incomingByte=='l'){
    if(s6==true){
        pixels.setPixelColor(10, yellow);
        pixels.show(); 
        s6=false;
        }else{
        pixels.setPixelColor(10, 0,0,0);
        pixels.show(); 
        s6=true;
        }
    }
    if(incomingByte=='m'){
    if(s7==true){
        pixels.setPixelColor(11, yellow);
        pixels.show(); 
        s7=false;
        }else{
        pixels.setPixelColor(11, 0,0,0);
        pixels.show(); 
        s7=true;
        }
    }
    if(incomingByte=='n'){
    if(s8==true){
        pixels.setPixelColor(12, yellow);
        pixels.show(); 
        s8=false;
        }else{
        pixels.setPixelColor(12, 0,0,0);
        pixels.show(); 
        s8=true;
        }
    }
    if(incomingByte=='o'){
    if(s9==true){
        pixels.setPixelColor(13, yellow);
        pixels.show(); 
        s9=false;
        }else{
        pixels.setPixelColor(13, 0,0,0);
        pixels.show(); 
        s9=true;
        }
    }
    if(incomingByte=='p'){
    if(s10==true){
        pixels.setPixelColor(14, yellow);
        pixels.show(); 
        s10=false;
        }else{
        pixels.setPixelColor(14, 0,0,0);
        pixels.show(); 
        s10=true;
        }
    }
    if(incomingByte=='z'){
for(int i=0;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Blank
    pixels.show();   
  }
    if(gt==true){
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, green); // Blank
    pixels.show();   
  }
      gt=false;
    }else{
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Green
    pixels.show();  
  }
      gt=true;
    }
    }



    if(incomingByte=='w'){
for(int i=0;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Blank
    pixels.show();   
  }
    if(red==true){
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, red); // Blank
    pixels.show();   
  }
      red=false;
    }else{
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Blank
    pixels.show();   
  }
      red=true;
    }
    }
//SC

        if(incomingByte=='x'){
for(int i=0;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Blank
    pixels.show();   
  }
    if(sc==true){
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, blue); // Blank
    pixels.show();   
  }
      sc=false;
    }else{
for(int i=5;i<NUMPIXELS;i++){
    pixels.setPixelColor(i, 0,0,0); // Green
    pixels.show();  
  }
      sc=true;
    }
    }
  }
}
 