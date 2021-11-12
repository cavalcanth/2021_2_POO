using System;

class Program {
  public static void Main (string[] args) {        
    double x1, y1, x2, y2;
    
    string[] vet1 = Console.ReadLine().Split(' ');
    string[] vet2 = Console.ReadLine().Split(' ');
    
    x1 = double.Parse(vet1[0]);
    y1 = double.Parse(vet1[1]);
    x2 = double.Parse(vet2[0]);
    y2 = double.Parse(vet2[1]);

        
    Console.WriteLine($"{(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2))):0.0000}");
  }
}