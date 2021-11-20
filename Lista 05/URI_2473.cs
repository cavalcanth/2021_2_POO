using System;

class Program {
  public static void Main (string[] args) {        
    int[] aposta = new int[6];  
    int[] sorteado = new int[6];
    int contador = 0;
    		
		String[] a = Console.ReadLine().Split(' ');
    aposta[0] = int.Parse(a[0]);
    aposta[1] = int.Parse(a[1]);
    aposta[2] = int.Parse(a[2]);
    aposta[3] = int.Parse(a[3]);
    aposta[4] = int.Parse(a[4]);
    aposta[5] = int.Parse(a[5]);

    String[] s = Console.ReadLine().Split(' ');
    sorteado[0] = int.Parse(s[0]);
    sorteado[1] = int.Parse(s[1]);
    sorteado[2] = int.Parse(s[2]);
    sorteado[3] = int.Parse(s[3]);
    sorteado[4] = int.Parse(s[4]);
    sorteado[5] = int.Parse(s[5]);
    
    for (int i = 0; i < 6; i++){
      for (int j = 0; j < 6; j++){
        if (aposta[i] == sorteado[j])
          contador++;
      }
    }

    if (contador == 3)
      Console.WriteLine("Terno");
    else if (contador == 4)
      Console.WriteLine("Quadra");
    else if (contador == 5)
      Console.WriteLine("Quina");
    else if (contador == 6)
      Console.WriteLine("Sena");
    else if (contador < 3)
      Console.WriteLine("azar");

  }
}