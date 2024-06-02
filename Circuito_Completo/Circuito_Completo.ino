#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <ArduinoJson.h>

LiquidCrystal_I2C lcd(0x27, 20, 4); // Inicializa la pantalla LCD con la dirección I2C 0x27 (puede variar)

const int motorPin = 9; // Pin de control del motor
const int switchPin = 2; // Pin conectado al NO del switch
const int waterSensorPin = 4; // Pin conectado al sensor de agua
int switchState = 0;
int lastSwitchState = LOW;
unsigned long startTime = 0;
unsigned long totalRunTime = 0; // Tiempo total que la bomba estuvo activa
unsigned long lastRunTime = 0; // Tiempo que tardó la bomba hasta que tocó el agua
unsigned long runTime = 0; // Tiempo que la bomba debe estar encendida
bool motorRunning = false;
bool canActivateMotor = true; // Nuevo flag para controlar la activación del motor
double cantidadDespacho = 0.0; // Definir cantidadDespacho aquí

void setup() {
  Serial.begin(9600);
  pinMode(motorPin, OUTPUT);
  pinMode(switchPin, INPUT);
  pinMode(waterSensorPin, INPUT);
  lcd.init();
  lcd.backlight();
  lcd.clear();
  lcd.setCursor(3, 1);
  lcd.print("  Gasolinera");
  lcd.setCursor(4, 2);
  lcd.print("     UMES");
}

void loop() {
  if (Serial.available() > 0) {
    String json = Serial.readStringUntil('\n');
    
    StaticJsonDocument<200> doc;
    DeserializationError error = deserializeJson(doc, json);

    if (error) {
        Serial.print(F("deserializeJson() failed: "));
        Serial.println(error.f_str());
        return;
    }

    const char* tipoDespacho = doc["TipoDespacho"];
    cantidadDespacho = doc["CantidadDespacho"];

    Serial.print("Tipo de Despacho: ");
    Serial.println(tipoDespacho);
    Serial.print("Cantidad de Despacho (Segundos): ");
    Serial.println(cantidadDespacho);

    runTime = cantidadDespacho * 1000; // Convertir segundos a milisegundos

    // Mostrar ml pedidos al recibir nuevo JSON
    lcd.clear();
    lcd.setCursor(3, 1);
    lcd.print("ml Pedidos:");
    lcd.print(cantidadDespacho);
    delay(3000); // Mostrar por 3 segundos
  }

  switchState = digitalRead(switchPin);
  int waterSensorState = readWaterSensor(); // Usamos la función de lectura filtrada del sensor de agua

  if (switchState == HIGH && lastSwitchState == LOW && canActivateMotor) {
    if (!motorRunning) {
      startTime = millis();
      motorRunning = true;
      digitalWrite(motorPin, HIGH);
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Bomba ON");
    }
  }

  if (motorRunning) {
    unsigned long currentTime = millis();
    unsigned long elapsedTime = currentTime - startTime;
    unsigned long remainingTime = runTime - elapsedTime;
    unsigned long remainingMinutes = remainingTime / 60000;
    unsigned long remainingSeconds = (remainingTime % 60000) / 1000;

    lcd.setCursor(0, 1);
    if (remainingMinutes < 10) lcd.print("0");
    lcd.print(remainingMinutes);
    lcd.print(":");
    if (remainingSeconds < 10) lcd.print("0");
    lcd.print(remainingSeconds);

    if (waterSensorState == HIGH || elapsedTime >= runTime) {
      motorRunning = false;
      canActivateMotor = false; // Impedir reactivación hasta que el interruptor se ponga en LOW
      digitalWrite(motorPin, LOW);
      lastRunTime = elapsedTime;
      totalRunTime += lastRunTime;
      cantidadDespacho = lastRunTime / 1000.0; // Actualizar cantidadDespacho con el tiempo en segundos

      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Bomba OFF");

      if (waterSensorState == HIGH) {
        lcd.setCursor(0, 1);
        lcd.print("Tanque Full");
      }

      lcd.setCursor(0, 2);
      lcd.print("ml servidos: ");
      lcd.print(cantidadDespacho);

      // Crear y enviar JSON al terminar
      StaticJsonDocument<200> doc;
      doc["lastRunTime"] = lastRunTime;
      String json;
      serializeJson(doc, json);

      Serial.println(json);
    }
  }

  if (switchState == LOW) {
    canActivateMotor = true; // Permitir reactivación cuando el interruptor se pone en LOW
  }

  lastSwitchState = switchState;
}

int readWaterSensor() {
  int total = 0;
  for (int i = 0; i < 10; i++) {
    total += digitalRead(waterSensorPin);
    delay(10);
  }
  return (total > 5) ? HIGH : LOW;
}
