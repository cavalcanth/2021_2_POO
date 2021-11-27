using System;

class Program {
  public static void Main (string[] args) {        
    double nota = 0, nota1 = 0, nota2 = 0, media = 0;        
    
    nota = double.Parse(Console.ReadLine());
    nota1 = nota;

    while (nota1 < 1 || nota1 > 10){
      nota1 = double.Parse(Console.ReadLine());
      if ((nota1 < 1 || nota1 > 10) || (nota < 1 || nota > 10))
        Console.WriteLine("nota invalida");      
    }

    nota = double.Parse(Console.ReadLine());
    nota2 = nota;
    
    while (nota2 < 1 || nota2 > 10){
      nota2 = double.Parse(Console.ReadLine());
      if ((nota2 < 1 || nota2 > 10) || (nota < 1 || nota > 10))
        Console.WriteLine("nota invalida");
    } 

    media = (nota1+nota2)/2;
    Console.WriteLine("media = "+$"{media:0.00}");
    
  }
}