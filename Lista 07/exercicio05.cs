using System;

class Program {

  public static string FormatarTexto(string texto){        
    
    texto = texto.Replace("  ", " ");    
    
    return texto.Trim();
  }

  public static void Main (string[] args) {
        
    string t = Console.ReadLine();    
    
    Console.WriteLine(FormatarTexto(t));
    
  }
}
