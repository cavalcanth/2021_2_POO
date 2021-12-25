using System;

class MainClass{
  public static void Main (string[] args){
    //int[] v1 = new int[10];
    
    int[] v2 = {1, 3, 5, 7, 9, 2, 4, 6, 8, 0}; //Não precisa do NEW

    for (int i = 0; i < v2.Length; i++)
      Console.WriteLine(v2[i]);
    
    Console.WriteLine();

    Array.Sort(v2);
    Array.Reverse(v2);

    foreach (int e in v2)
      Console.WriteLine(e);

    int[] v3 = (int[]) v2.Clone();
    v3[0] = 20;
    v3[9] = 40;

    Console.WriteLine();

    foreach (int e in v3)
     Console.WriteLine(e);


  }
}
