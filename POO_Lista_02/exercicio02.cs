using System;

class Program {
  public static void Main (string[] args) {

    Disciplina d = new Disciplina();
    
    Console.WriteLine("Informe o nome da disciplina: ");
    d.setNome(Console.ReadLine());

    Console.WriteLine("Informe a nota 1 (0 a 100): ");
    d.setNota1(double.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a nota 2 (0 a 100): ");
    d.setNota2(double.Parse(Console.ReadLine()));
    
    Console.WriteLine("Informe a nota 3 (0 a 100): ");
    d.setNota3(double.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a nota 4 (0 a 100): ");
    d.setNota4(double.Parse(Console.ReadLine()));

    if (d.CalcMediaParcial() >= 60)      
      Console.WriteLine("Aprovado!");
    else{
      Console.WriteLine("Informe a nota da prova final (0 a 100): ");
      d.nota_prova_final = double.Parse(Console.ReadLine());

      if (d.CalcMediaFinal() >= 60)
        Console.WriteLine("Aprovado!");
      else
        Console.WriteLine("Reprovado!");

    }
 
  }
}

class Disciplina{
  public string nome;
  public double nota1, nota2, nota3, nota4, nota_prova_final;

  public void setNome(string v){
    nome = v;
  }
  public string getNome(){
    return nome;
  }

  public void setNota1(double v){
    nota1 = v;
  }
  public double getNota1(){
    return nota1;
  }

  public void setNota2(double v){
    nota2 = v;
  }
  public double getNota2(){
    return nota2;
  }

  public void setNota3(double v){
    nota3 = v;
  }
  public double getNota3(){
    return nota3;
  }

  public void setNota4(double v){
    nota4 = v;
  }
  public double getNota4(){
    return nota4;
  }

  public void setNotaFinal(double v){
    nota_prova_final = v;
  }
  public double getNotaFinal(){
    return nota_prova_final;
  }

  double media = 0;

  public double CalcMediaParcial(){    

    if ((nota1 >= 0 && nota1 <= 100) && (nota2 >= 0 && nota2 <= 100) && (nota3 >= 0 && nota3 <= 100) && (nota4 >= 0 && nota4 <= 100)){

      media = (nota1*2 + nota2*2 + nota3*3 + nota4*3)/10;
      
    }

    return media;
    
  }
  
  public double CalcMediaFinal(){

    double mediaFinal = (media + nota_prova_final)/2;

    return mediaFinal;

  }
}