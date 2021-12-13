using System;

class Program {
  public static void Main (string[] args) {

    Conta c = new Conta();    
    Console.WriteLine("Informe o nome do titular: ");
    c.nome = Console.ReadLine();

    Console.WriteLine("Informe o número da conta: ");
    c.nCont = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe o saldo: ");
    c.saldo = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe 1 - Depósito ou 2 - Saque: ");
    c.op = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe um valor para a operação: ");
    c.valor = double.Parse(Console.ReadLine());

    if (c.op == 1) 
      Console.WriteLine(c.CalcDep());
  
    if (c.op == 2) 
      Console.WriteLine(c.CalcSaq());     
             
  }
}

class Conta{
  public string nome;
  public int nCont, op = 0;
  public double saldo, valor;
  
  public double CalcDep(){    
    return saldo+valor;
  }
  
  public double CalcSaq(){    
    return saldo-valor;
  }

}