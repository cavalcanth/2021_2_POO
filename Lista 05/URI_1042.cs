using System;

class Program {
  public static void Main (string[] args) {        
    int a, b, c;

    String[] v = Console.ReadLine().Split(' ');
    
    a = int.Parse(v[0]);
    b = int.Parse(v[1]);
    c = int.Parse(v[2]);

    if (a < b && a < c && b < c){
      
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
      
    }else if (a < b && a < c && b > c){
    
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(b);

    }else if ( a > b && b < c && a < c){
    
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine(c);

    }else if (a > b && b < c && a > c){
      
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(a);

    }else if (a < b && b > c && a > c){

        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine(b);

    }else if (a > b && b > c && a > c){

        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a);        
    }

    Console.WriteLine("");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    
  }
}