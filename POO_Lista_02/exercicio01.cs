using System;

class Program {
  public static void Main (string[] args) {

    Circulo c = new Circulo();
    
    c.setRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine(c.CalcArea());    
    Console.WriteLine(c.CalcCircunferencia());
    
  }
}

class Circulo{
  private double raio;

  public void setRaio(double v){
    raio = v;
  }
  public double getRaio(){
    return raio;
  }

  public double CalcArea(){    
    double area = 3.14*Math.Pow(raio, 2);
    return area;
  }
  public double CalcCircunferencia(){
    double comp = 2 * 3.14 * raio;
    return comp;
  }
}