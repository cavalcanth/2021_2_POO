using System;

class Program {

  public static void Intervalo(double x, out int inicio, out int fim){
   
  inicio = (int) x;

  fim = inicio + 1;
      
}

  public static void Main (string[] args) {
    int a = 0, b = 0;
    
    double n = double.Parse(Console.ReadLine());
        
    Intervalo(n, out a, out b);
    
    Console.WriteLine($"O número {n} está entre {a} e {b}.");
    
  }
}
