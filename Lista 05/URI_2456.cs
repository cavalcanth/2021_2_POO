using System;

class Program {
  public static void Main (string[] args) {        
    int[] numeros = new int[5];  
    char ord = '-';
    int x = 0;
    int y = 0;
		
		String[] v = Console.ReadLine().Split(' ');
    numeros[0] = int.Parse(v[0]);
    numeros[1] = int.Parse(v[1]);
    numeros[2] = int.Parse(v[2]);
    numeros[3] = int.Parse(v[3]);
    numeros[4] = int.Parse(v[4]);
		
		for (int c = 0; c <= 3; c++ ){
      if (numeros[c] < numeros[c+1]){
        ord = 'C';
        x += 1;
      }     
    }
    
    for (int c = 0; c <= 3; c++ ){
      if (numeros[c] > numeros[c+1]){
        ord = 'D';
        y += 1; 
      }     
    } 
    
    if (ord == 'C' && x == 4)
      Console.WriteLine('C');
    else if (ord == 'D' && y == 4)
      Console.WriteLine('D');
    else
      Console.WriteLine('N');
    
  }
}