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
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura{
    get { return h; }
    set { if (value > 0) h = value; }
  }
  
  public double Area{
    get { return b * h / 2; }
  }
  public override string ToString(){ 
    return $"Base = {b}, Altura = {h}";
  }
}