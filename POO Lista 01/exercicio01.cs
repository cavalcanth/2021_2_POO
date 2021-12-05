using System;

class Program {
  public static void Main (string[] args) {

    Circulo x = new Circulo();
    //x.r = 3;
    x.r = double.Parse(Console.ReadLine());
    Console.WriteLine(x.CalcArea());    
    Console.WriteLine(x.CalcCircunferencia());
    
  }
}

class Circulo{
  public double r;
  public double CalcArea(){
    double area = 3.14*Math.Pow(r, 2);
    return area;
  }
  public double CalcCircunferencia(){
    double comp = 2 * 3.14 * r;
    return comp;
  }
}