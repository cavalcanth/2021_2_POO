using System;

class Program {
  public static void Main (string[] args) {                 int t;    
    char letra = '-';     

    while (letra != '*'){
      string[] frase = Console.ReadLine().Split(' ');     

      letra = frase[0][0];
      t = frase.Length;

      for (int c = 0; c < t; c++){
        frase[c] = frase[c].ToUpper();      
      }     

      for (int c = 0; c < t-1; c++){
        
        if (frase[c][0] == frase[c+1][0]){
          Console.WriteLine("Y");           
          break;         
        }
        if (frase[c][0] != frase[c+1][0]){
          Console.WriteLine("N");          
          break;
        }        
        
      }
      
    }    
    
  }
}