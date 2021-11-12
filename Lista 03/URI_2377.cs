using System;

class Program {
  public static void Main (string[] args) {        
    int l, d, k, p;
    
    string[] v1 = Console.ReadLine().Split(' ');
    string[] v2 = Console.ReadLine().Split(' ');
    
    l = int.Parse(v1[0]);
    d = int.Parse(v1[1]);
    k = int.Parse(v2[0]);
    p = int.Parse(v2[1]);
    
    Console.WriteLine($"{l*k + (l/d)*p}");
  }
}