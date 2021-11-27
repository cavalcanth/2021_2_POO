using System;

class Program {
  public static void Main (string[] args) {        
    int dia_i, hora_i, min_i, seg_i, dia_f, hora_f, min_f, seg_f, segundos_i, segundos_f, dif, dia, hora, min, seg;
    

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

    segundos_i = seg_i + (min_i*60) + (hora_i*60*60) + (dia_i*24*60*60);
    segundos_f = seg_f + (min_f*60) + (hora_f*60*60) + (dia_f*24*60*60);

    dif = segundos_f - segundos_i;

    dia = dif / 86400; // 1 dia = 24h * 3600s

    dif = dif % 86400;

    hora = dif / 3600;

    dif = dif % 3600;

    min = dif / 60;

    seg = dif % 60;

    Console.WriteLine($"{dia} dia(s)");
    Console.WriteLine($"{hora} hora(s)");
    Console.WriteLine($"{min} minuto(s)");
    Console.WriteLine($"{seg} segundo(s)");
  }
}