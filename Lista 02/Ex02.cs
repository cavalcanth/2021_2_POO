using System;

class Program {
  public static void Main (string[] args) {
    string nome;
    Console.WriteLine ("Digite seu nome completo: ");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Bem-vindo ao C#, {nome.Substring(0, nome.IndexOf(" "))}");
  }
}