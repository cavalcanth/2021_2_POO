using System;

class Program {

  public static double Maior(double x, double y){
      double maior = 0;
      if (x > y)
        maior = x;
      else
        maior = y;
      return maior; 
    }

  public static void Main (string[] args) {
    
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    double r = Maior(a, b);
    
    Console.WriteLine($"Maior = {r}");
    
  }
}
