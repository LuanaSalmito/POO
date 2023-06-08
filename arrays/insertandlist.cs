using System;

public class Colecao
{
    private int max;
    private object[] elementos;
    private int numItens;

    public Colecao(int max)
    {
        this.max = max;
        this.elementos = new object[max];
        this.numItens = 0;
    }

    public void Inserir(object obj)
    {
        if (numItens < max)
        {
            elementos[numItens] = obj;
            numItens++;
        }
        else
        {
            Console.WriteLine("A coleção já está cheia.");
        }
    }

    public void Listar()
    {
        for (int i = 0; i < numItens; i++)
        {
            Console.WriteLine(elementos[i].ToString());
        }
    }

    public int NumItens
    {
        get { return numItens; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite o número de itens na coleção desejada: ");
      int n = int.Parse(Console.ReadLine());
      
      Colecao colecao = new Colecao(n);

      for(int i = 0; i < n; i++){
        object x = Console.ReadLine();
        colecao.Inserir(x);
      }
        Console.WriteLine("Elementos da coleção:");
        colecao.Listar();

        Console.WriteLine("Número de itens na coleção: " + colecao.NumItens);



        Console.WriteLine("Número de itens na coleção: " + colecao.NumItens);
    }
}