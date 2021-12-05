using System;

class Program {
  public static void Main (string[] args) {                 
    int n = int.Parse(Console.ReadLine());           
    
    for (int i = 0; i < n; i++){

      int x = int.Parse(Console.ReadLine());
      int total = 0;

      if (x == 2) Console.WriteLine("Prime");
      
      else if (x % 2 == 0) Console.WriteLine("Not Prime"); 
      else{

        for (int j = 3; j <= Math.Sqrt(x); j+=2){

          if (x % j == 0) total++;

        }

        if (total >= 1) Console.WriteLine("Not Prime");

        else Console.WriteLine("Prime");

      }             
              
    }   
    
  }
}