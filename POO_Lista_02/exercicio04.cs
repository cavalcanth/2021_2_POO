using System;

class Program {
  public static void Main (string[] args) {

    Conta c = new Conta();    
    Console.WriteLine("Informe o nome do titular: ");
    c.setNome(Console.ReadLine());

    Console.WriteLine("Informe o número da conta: ");
    c.setNumCont(int.Parse(Console.ReadLine()));
    
    Console.WriteLine("Informe o saldo: ");
    c.setSaldo(double.Parse(Console.ReadLine()));

    Console.WriteLine("Informe 1 - Depósito ou 2 - Saque: ");
    c.setOperacao(int.Parse(Console.ReadLine()));

    Console.WriteLine("Informe um valor para a operação: ");
    c.setValor(double.Parse(Console.ReadLine()));

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

  public void setNome(string v){
    nome = v;
  }
  public string getNome(){
    return nome;
  }

  public void setNumCont(int v){
    nCont = v;
  }
  public double getNumCont(){
    return nCont;
  }

  public void setOperacao(int v){
    op = v;
  }
  public double getOperacao(){
    return op;
  }

  public void setSaldo(double v){
    saldo = v;
  }
  public double getSaldo(){
    return saldo;
  }

  public void setValor(double v){
    valor = v;
  }
  public double getValor(){
    return valor;
  }
  

  public double CalcDep(){    
    return saldo+valor;
  }
  
  public double CalcSaq(){    
    return saldo-valor;
  }

}