using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2;
    Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina: ");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina: ");
    n2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"Média parcial = {(n1*2 + n2*3)/5}");
  }
}
