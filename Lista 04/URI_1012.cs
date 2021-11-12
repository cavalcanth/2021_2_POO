using System;

class Program {
  public static void Main (string[] args) {        
    double a, b, c;
    
    string[] vetor = Console.ReadLine().Split(' ');
    
    a = double.Parse(vetor[0]);
    b = double.Parse(vetor[1]);
    c = double.Parse(vetor[2]);

    Console.WriteLine($"TRIANGULO: {((a*c)/2):0.000}");
    Console.WriteLine($"CIRCULO: {(Math.Pow(c, 2)*3.14159):0.000}");
    Console.WriteLine($"TRAPEZIO: {(((a+b)*c)/2):0.000}");
    Console.WriteLine($"QUADRADO: {(Math.Pow(b, 2)):0.000}");
    Console.WriteLine($"RETANGULO: {(a*b):0.000}");
    
  }
}