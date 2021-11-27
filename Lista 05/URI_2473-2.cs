using System;

class Program {
  public static void Main (string[] args) {        
    string aposta = Console.ReadLine();
    string result = Console.ReadLine();
    string[] a = aposta.Split(' ');
    string[] r = result.Split(' ');
    int s = 0;

    if (a[0] == r[0] || a[0] == r[1] || a[0] == r[2] || a[0] == r[3] || a[0] == r[4] || a[0] == r[5]) s++;
    
    if (a[1] == r[0] || a[1] == r[1] || a[1] == r[2] || a[1] == r[3] || a[1] == r[4] || a[1] == r[5]) s++;

    if (a[2] == r[0] || a[2] == r[1] || a[2] == r[2] || a[2] == r[3] || a[2] == r[4] || a[2] == r[5]) s++;

    if (a[3] == r[0] || a[3] == r[1] || a[3] == r[2] || a[3] == r[3] || a[3] == r[4] || a[3] == r[5]) s++;

    if (a[4] == r[0] || a[4] == r[1] || a[4] == r[2] || a[4] == r[3] || a[4] == r[4] || a[4] == r[5]) s++;

    if (a[5] == r[0] || a[5] == r[1] || a[5] == r[2] || a[5] == r[3] || a[5] == r[4] || a[5] == r[5]) s++;

    if (s == 3) Console.WriteLine("terno");
    if (s == 4) Console.WriteLine("quadra");
    if (s == 5) Console.WriteLine("quina");
    if (s == 6) Console.WriteLine("sena");
    if (s < 3) Console.WriteLine("azar");

  }
}