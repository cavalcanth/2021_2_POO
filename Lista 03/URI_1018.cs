using System;

class Program {
  public static void Main (string[] args) {        
    int n, d100, d50, d20, d10, d5, d2, d1;
        
    n = int.Parse(Console.ReadLine());

    d100 = n/100;
    d50 = n%100;
    d20 = d50%50;
    d10 = d20%20;
    d5 = d10%10;
    d2 = d5%5;
    d1 = d2%2;
    
    Console.WriteLine($"{n}");
    Console.WriteLine($"{d100} nota(s) de R$ 100,00");
    Console.WriteLine($"{d50/50} nota(s) de R$ 50,00");
    Console.WriteLine($"{d20/20} nota(s) de R$ 20,00");
    Console.WriteLine($"{d10/10} nota(s) de R$ 10,00");
    Console.WriteLine($"{d5/5} nota(s) de R$ 5,00");
    Console.WriteLine($"{d2/2} nota(s) de R$ 2,00");
    Console.WriteLine($"{d1} nota(s) de R$ 1,00");

  }
}