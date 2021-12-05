using System;

class Program {
  public static void Main (string[] args) { 

    bool teste = true;
    double dist = 0;        

    while (teste){
      string[] v = Console.ReadLine().Split(' ');
      int d = int.Parse(v[0]);
      int vf = int.Parse(v[1]);
      int vg = int.Parse(v[2]);

      if (d > 0 || vf > 0 || vg > 0){
        
        dist = Math.Sqrt(Math.Pow(12.0, 2.0) + Math.Pow(d, 2.0));
        
        if ((12.0 / vf) >= (dist / vg)){
          Console.WriteLine("S");
        }else{
          Console.WriteLine("N");
        }        

      }else teste = false;

    }   
    
  }
}