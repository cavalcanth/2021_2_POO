using System;

class Program {
  public static void Main (string[] args) {        
    int t, v;
    
    t = int.Parse(Console.ReadLine());
    v = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"{(t*v/12.0):0.000}");
    
  }
}