using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um valor inteiro entre 1 e 12: ");
    int x = int.Parse(Console.ReadLine());

    switch (x){
      case 1: Console.WriteLine("janeiro"); break;
      case 2: Console.WriteLine("fevereiro"); break;
      case 3: Console.WriteLine("março"); break;
      case 4: Console.WriteLine("abril"); break;
      case 5: Console.WriteLine("maio"); break;
      case 6: Console.WriteLine("junho"); break;
      case 7: Console.WriteLine("julho"); break;
      case 8: Console.WriteLine("agosto"); break;
      case 9: Console.WriteLine("setembro"); break;
      case 10: Console.WriteLine("outubro"); break;
      case 11: Console.WriteLine("novembro"); break;
      case 12: Console.WriteLine("dezembro"); break;
      default: Console.WriteLine("Número do mês errado"); break;

    }
    
  }
}
