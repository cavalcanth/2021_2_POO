using System;

class Program {
  public static void Main (string[] args) {
    string nome;
    double salario, vendas;
    
    nome = Console.ReadLine();
    
    salario = double.Parse(Console.ReadLine());
    vendas = double.Parse(Console.ReadLine());
    
    Console.WriteLine($"TOTAL = R$ {((0.15*vendas)+salario):0.00}");
  }
}