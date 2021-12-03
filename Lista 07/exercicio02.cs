using System;

class Program {  

  public static void Main (string[] args) {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    int z = int.Parse(Console.ReadLine());
    

    Ordenar(ref x, ref y, ref z);            
  }

  public static void Ordenar(ref int a, ref int b, ref int c){

    int ord1 = 0, ord2 = 0, ord3 = 0;
    
    if (a < b && a < c){
      ord1 = a;      
      if (b < c){
        ord2 = b;
        ord3 = c;        
      }else{
        ord2 = c;
        ord3 = b;
      }
    }

    if (b < c && b < a){
      ord1 = b;      
      if (a < c){
        ord2 = a;
        ord3 = c;        
      }else{
        ord2 = c;
        ord3 = a;
      }
    }

    if (c < a && c < b){
      ord1 = c;      
      if (b < a){
        ord2 = b;
        ord3 = a;        
      }else{
        ord2 = a;
        ord3 = b;
      }
    }
           
    Console.WriteLine($"{ord1}, {ord2} e {ord3}");
  }
}
