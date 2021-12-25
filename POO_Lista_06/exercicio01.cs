using System;

class MainClass{
  public static void Main (string[] args){
    Colecao time = new Time("XYZ");
    Jogador j1 = new Jogador("ABC", 10);
    Jogador j2 = new Jogador("DEF", 20);
    time.Inserir(j1);
    time.Inserir(j2);

    foreach (Jogador x in time.Listar())
      Console.WriteLine(x);
    
  }
}

class Item{  

}

class Colecao{  
  private Item[] itens;
  private int max;

  public Colecao(int max){
    this.max = max;
    itens = new Item[6];
  }

  public void Inserir(Item x){
    if (k < 6){
      itens[k] = x;
      k++;
    }
  }
  
  public Item[] Listar(){
    Item[] i = new Item[k];
    Array.Copy(itens, i, k);
    return r;
  }

}
