using System;

class Program {
  public static void Main (string[] args) {
    double b, h, a, p, d;
    Console.WriteLine ("Digite a base e a altura do retângulo: ");
    b = double.Parse(Console.ReadLine());    
    h = double.Parse(Console.ReadLine());
    a = b * h;
    p = 2*b + 2*h;
    d = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    Console.WriteLine($"Área = {a:0.00} - Perímetro = {p:0.00} - Diagonal = {d:0.00}");
  }
}
