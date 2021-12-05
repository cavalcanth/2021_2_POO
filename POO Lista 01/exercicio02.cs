using System;

class Program {
  public static void Main (string[] args) {

    Disciplina d = new Disciplina();
    
    Console.WriteLine("Informe o nome da disciplina: ");
    d.nome = Console.ReadLine();

    Console.WriteLine("Informe a nota 1 (0 a 100): ");
    d.nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota 2 (0 a 100): ");
    d.nota2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe a nota 3 (0 a 100): ");
    d.nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota 4 (0 a 100): ");
    d.nota4 = double.Parse(Console.ReadLine());

    if (d.CalcMediaParcial() >= 60)
      Console.WriteLine("Aprovado 1!");
    else{
      Console.WriteLine("Informe a nota da prova final (0 a 100): ");
      d.nota_prova_final = double.Parse(Console.ReadLine());

      if (d.CalcMediaFinal() >= 60)
        Console.WriteLine("Aprovado 2!");
      else
        Console.WriteLine("Reprovado!");

    }
 
  }
}

class Disciplina{
  public string nome;
  public double nota1, nota2, nota3, nota4, nota_prova_final;
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