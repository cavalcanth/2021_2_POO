using System;
[Flags]
enum Cores{ Amarela = 1, Azul, Vermelha, Roxa, Laranja, Verde, Marrom, Preta}

class MainClass{
  public static void Main (string[] args){
    Cores bola1 = Cores.Amarela;
    Cores bola2 = Cores.Azul;
    Cores sinuca = Cores.Amarela | Cores.Azul;
    Console.WriteLine(sinuca);
  }
}
