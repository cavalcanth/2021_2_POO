using System;

class Program {
  public static void Main (string[] args) {        
    int dia_i, hora_i, min_i, seg_i, dia_f, hora_f, min_f, seg_f, dias, horas, minutos, segundos;
    

    string[] v1 = Console.ReadLine().Split(' ');
    string[] v2 = Console.ReadLine().Split(':');
    string[] v3 = Console.ReadLine().Split(' ');
    string[] v4 = Console.ReadLine().Split(':');

    
    dia_i = int.Parse(v1[1]);
    hora_i = int.Parse(v2[0]);
    min_i = int.Parse(v2[1]);
    seg_i = int.Parse(v2[2]);

    dia_f = int.Parse(v3[1]);
    hora_f = int.Parse(v4[0]);
    min_f = int.Parse(v4[1]);
    seg_f = int.Parse(v4[2]);

    dias = dia_f - dia_i;
    horas = hora_f - hora_i;

    if (horas < 0){
      horas += 24;
      dias = dias -= 1;      
    }

    minutos = min_f - min_i;

    if (minutos < 0){
      minutos += 60;
      horas -= 1;
    }

    segundos = seg_f - seg_i;

    if (segundos < 0){
      segundos += 60;
      minutos -= 1;
    }    
    
    Console.WriteLine($"{dias} dia(s)");
    Console.WriteLine($"{horas} hora(s)");
    Console.WriteLine($"{minutos} minuto(s)");
    Console.WriteLine($"{segundos} segundo(s)");
    
  }
}