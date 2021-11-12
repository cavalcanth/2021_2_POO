using System;

class Program {
  public static void Main (string[] args) {
    string t;    
    long h, m, s, d;
    Console.WriteLine ("Digite o intervalo de tempo no formato “HH:MM:SS” ");
    t = Console.ReadLine();    
    h = long.Parse(t.Substring(0, 2));
    m = long.Parse(t.Substring(3, 2));
    s = long.Parse(t.Substring(6, 2));
        
    d = h*3600 + m*60 + s;


    Console.WriteLine($"A luz percorreu {d*300000} km nesse intervalo");
  }
}