using System;

class Program {
  public static void Main (string[] args) {
    
    Triangulo x = new Triangulo();

    x.Base = 100;
    x.Altura = 400;
    
    Console.WriteLine(x.Area);
    
  }
}

class Triangulo{
  private double b, h;
  public Triangulo(){} //construtor padrão que não recebe parâmetros
  
  public double Base{
    get => b; 
    set => b = value > 0 ? value : 0;
  }
  public double Altura{
    get => h; 
    set => h = value > 0 ? value : 0;
  }
  
  public double Area{
    get { return b * h / 2; }
  }
  public override string ToString(){ 
    return $"Base = {b}, Altura = {h}";
  }
}