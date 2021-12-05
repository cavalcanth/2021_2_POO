using System;

class Program {

  public static int MMC(int x, int y){

    int d, q;

    d = x;
    q = y;

    while (q != 0){
      int r = d%q;
      d = q;
      q = r;
    }

    return x * y/d; 
    }

  public static void Main (string[] args) {
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"MMC = {MMC(a, b)}");
    
  }
}
