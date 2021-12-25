using System;

class Program {
  public static void Main (string[] args) {

    Viagem v = new Viagem();    
    Console.WriteLine("Informe a distância (km): ");
    v.d = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o tempo (HH:MM): ");
    string[] tempo = Console.ReadLine().Split(":");    
    
    int hora = int.Parse(tempo[0]);
    int minuto = int.Parse(tempo[1]);

    v.t = hora*3600 + minuto*60;
    
    Console.WriteLine($"A velocidade média foi de {v.CalcVelMed():0.00} km/h");    
        
  }
}

class Viagem{
  public double d;
  public int t;

  public void setDistancia(double v){
    d = v;
  }
  public double getDistancia(){
    return d;
  }

  public void setTempo(int v){
    t = v;
  }
  public double getTempo(){
    return t;
  }
  
  public double CalcVelMed(){
    double vel = (d*1000)/t;    
    return vel/3.6;
  }
  
}