using System;

class Program {
  public static void Main (string[] args) {

    Retangulo x = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    
    Console.WriteLine(x.CalcArea());    
    Console.WriteLine(x.CalcDiagonal());
    Console.WriteLine(x.ToString());

    x = null;
    
  }
}

class Retangulo{
  private double b, h;  

  public Retangulo(double b, double h){
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  
  public void setBase(double b){
    if (b > 0) this.b = b;
  }

  public void setAltura(double h){
    if (h > 0) this.h = h;
  }

  public double getBase(){
    return b;
  }

  public double getAltura(){
    return h;
  }
  
  public double CalcArea(){    
    double area = b*h;
    return area;
  }

  public double CalcDiagonal(){
    double diag = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    return diag;
  }

  public override string ToString(){
    return $"Base = {b}, Altura = {h}";
  }
}