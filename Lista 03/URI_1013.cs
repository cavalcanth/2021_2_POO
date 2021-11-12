using System;

class Program {
  public static void Main (string[] args) {        
    int a, b, c, d;
    
    string[] vetor = Console.ReadLine().Split(' ');
    
    a = int.Parse(vetor[0]);
    b = int.Parse(vetor[1]);
    c = int.Parse(vetor[2]);

    d = (a + b + Math.Abs(a-b))/2;
    
    Console.WriteLine($"{(d + c + Math.Abs(d-c))/2} eh o maior");
  }
}