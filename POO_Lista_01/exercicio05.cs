using System;

class Program {
  public static void Main (string[] args) {

    Cinema c = new Cinema();    
    Console.WriteLine("Informe o dia (1 - seg a 7 - dom): ");
    c.dia = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o horário (1 p/ 1h e 0 p/ 0h): ");
    c.horario = int.Parse(Console.ReadLine());    
    
    Console.WriteLine($"Valor R$ {c.CalcValIng():0.00}"); 
        
  }
}

class Cinema{
  public int dia;
  public int horario;
  
  public double CalcValIng(){
    double p = 0;
    switch (dia){
      case 1:
      case 2:
      case 4:
        p = 16;
        if (horario >= 17 && horario <= 24)
          p = p * 1.5;
        break;
      case 3:
        p = 8;
        break;
      case 5:
      case 6:
      case 7:
        p = 20;
        if (horario >= 17 && horario <= 24)
          p = p * 1.5;
        break;
    }
    return p;
  }
  
}