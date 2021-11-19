using System;

class Program {
  public static void Main (string[] args) {
    /*double x = AreaTriangulo(10, 20);
    double y = AreaTriangulo(5, 8);
    Console.WriteLine(x);
    Console.WriteLine(y);*/

    double x = Area.AreaTriangulo(10, 20);
    double y = Area.AreaTriangulo(5, 8);
    Console.WriteLine(x);
    Console.WriteLine(y);    

  }

  /*public static double AreaTriangulo (double b, double h){
    double area = b * h / 2;
    return area;
  }*/

  //Como o método está na mesma classe, pode ser definida por privado

  /*private static double AreaTriangulo (double b, double h){
    double area = b * h / 2;
    return area;
  }*/

  class Area{ //o métoddo deve ser público
    public static double AreaTriangulo (double b, double h){
      double area = b * h / 2;
      return area;
    }
  }

}
