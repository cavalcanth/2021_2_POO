using System;

class Program {
  public static void Main (string[] args) {
    // as variáveis locais ficam armanezenadas na área chamada stack. x é uma variável local. E as variáveis que alocam com NEW ficam na memória heap.
    Triangulo x = new Triangulo(10, 20);
    //x.SetBase(20);
    //x.SetAltura(20);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x);
    //Console.WriteLine(x.ToString());
    
    
  }
}

class Triangulo{
  private double b, h;
  public Triangulo(){} // Crio porque tem outro construtor
  public Triangulo(double b, double h){ //Criando um construtor pra classe
    if (b > 0) this.b = b; //qdo uso this é porque estou me referindo ao atributo do objeto.
     if (h > 0) this.h = h; //o valor que está em this, é o que vai está em x, ja que x é uma variável local do método main, não posso usá-lo aqui.
  }
  public void SetBase(double v){
    if (v > 0) b = v;
  }
  public void SetAltura(double v){
    if (v > 0) h = v;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    double area = b * h / 2;
    return area;
  }
  public override string ToString(){ //Sobrescrever o método ToString que é herdado da classe OBJECT. É uma forma de polimorfismo. Polimorfismo é qdo herdo um método de uma classe, e faço uma sobrescrita dele para que ele tenha uma outra forma de funcionamento.
    return $"Base = {b}, Altura = {h}";
  }
}