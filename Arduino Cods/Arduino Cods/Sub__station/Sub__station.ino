#include <Servo.h>
#include <SoftwareSerial.h> //importSerial Library

//Note: this code below based on a cod from: http://create.arduino.cc/projecthub/54183/smart-security-alarm-52323a 
//By: karen-d-kusuma and adjusted by Haeytham Almalak.


#define buzzer  13
#define sensor 2
#define LedBlue 7


bool snozeSatData = true;
Servo myservo;  // create servo object to control a servo 
int pos = 0;    // variable to store the servo position
int ValueOfData;
int timeCounter =  3 ; //second
int status=LOW;
int statusOfBuzzer=0;    //To turn on buzzer 
char data=0;          // data bluetooth (HC-05)

void setup() {
  pinMode(sensor,INPUT);
  pinMode(buzzer ,OUTPUT);
  pinMode(LedBlue,OUTPUT);

  myservo.attach(4);  // attaches the servo on pin 9 to the servo object
  Serial.begin(9600);
  myservo.write(0); 
  void calibration();
}
void loop() {
  readData();
  alarm();
  
}
//==============================Function ========== alarm ====================
void alarm(){
  ValueOfData=digitalRead(sensor);
  /*SENSOR PIR*/
  if(ValueOfData==HIGH) {                      //PIR detect, turn on the led and buzzer 
    digitalWrite(LedBlue, HIGH);           //LED ON  
    Serial.write(" Motion detected! ");
    Serial.println(" Motion detected! ");
    if (status==LOW) {
      //Serial.write(" Motion detected! ");
      //Serial.println(" ");
     // Serial.println(" Motion detected! ");
      //Serial.write(45);                   //Send serial data in bytes
      char bytesSent=Serial.write("Motion detected!");
      status=HIGH;
      statusOfBuzzer=1;                      //buzzer state initiation to 1/ON
      
    }
    else{}
  } 
  else{                                   //the buzzer is still on, even though the PIR doesn't detect it
    digitalWrite(LedBlue, LOW);            //LED OFF
    if(status==HIGH){
      //Serial.println(" ");////////////////////////////////++++++++++++++++++++++
      //Serial.println("Motion ended.");
      //Serial.write("Motion ended.");
      lockSecured();
      digitalWrite(buzzer , HIGH);
      //Serial.write(45);
      //char bytesSent=Serial.write("");
      status=LOW;
    }
    else{}
  }
  /*VOICE*/
  if(statusOfBuzzer==1){    
    digitalWrite(buzzer , HIGH);
  }
  else if(statusOfBuzzer==0){
    digitalWrite(buzzer , LOW);    
  }
}
//==============================Function ======== readData ======================
/*BLUETOOTH*/
void readData(){

  if(Serial.available()>0){           //Send data if it is available
    data = Serial.read();             //Read data
    Serial.println(" ");          
    Serial.println(data);          
    if(data=='1'){                    //ON
      lockSecured(); 
      digitalWrite(buzzer , HIGH);
      statusOfBuzzer=1;
      Serial.println("It Os ON Alarm by your Command");
      Serial.write(" It is ON Alarm now by your Command ");
     
    }
    if(data=='0'){               //OFF
      lockOpen();
  
      digitalWrite(sensor, LOW);
      statusOfBuzzer=0;
      Serial.println("The Station has reseated");
      Serial.write(" The Station has reseated ");

      }
    if(data=='2'){               //OFF
      lockOpen();
      Serial.write(" Snoozed ");
      digitalWrite(sensor, LOW);
      digitalWrite(buzzer , LOW);
      
      statusOfBuzzer=0;
      snozeSatData = false;
      Serial.println("Snoozed");
      
      delay(600000);
      snozeSatData = true;    
    }
  }
}

//==============================Function ============ Calibration ==================
void calibration(){  
  Serial.print("calibration");
  for(byte index =0; index < timeCounter; index++){
    Serial.print(".");
    LedB();
  }  
  digitalWrite(LedBlue,LOW);  
  Serial.println("\n");
  Serial.println("=finished=");
}
//==============================Function ======== Light ======================
void LedB(){
  for(short index =0; index<1; index++){    
    digitalWrite(LedBlue,LOW);    
    delay(500);
    digitalWrite(LedBlue,HIGH);
    delay(500);
  }
}
//==============================Function ======== DOOR LOCKED UNLOCKED ======================
void lockOpen(){
  
      myservo.write(0); 
      delay(10);
      Serial.write("  = >  Door Unlocked ! ");
      Serial.println("  = >  Door Unlocked ! "); 
}
void lockSecured(){      
        myservo.write(180);
       delay(10);
       Serial.write(" = > Door locked !  ");
       Serial.println("  = > Door locked !  "); 
}
 
