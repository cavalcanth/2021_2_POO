using System;

class Program {
  public static void Main (string[] args) {        
    int A, B, C, D;

    String[] v = Console.ReadLine().Split(' ');
    
    A = int.Parse(v[0]);
    B = int.Parse(v[1]);
    C = int.Parse(v[2]);
    D = int.Parse(v[3]);
    
    if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
      Console.WriteLine("Valores aceitos");
    else
      Console.WriteLine("Valores nao aceitos");
  }
}