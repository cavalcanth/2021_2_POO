using System;

class Program {
  public static void Main (string[] args) {
    
    int x;
    
    Console.WriteLine("Digite um valor inteiro: ");

    while (int.TryParse(Console.ReadLine(), out x) == false){
      
      Console.WriteLine("valor inteiro válido");
      Console.WriteLine("Digite novamente:");

    }

    Console.WriteLine(x);
  }    
}
