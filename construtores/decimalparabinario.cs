using System;

public class Converter
{
    private int num;

    public Converter(int num)
    {
        this.num = num;
    }
    public int Numero {public static void Main
        }
        else
        {
            Console.WriteLine("Erro, o número deve ser inteiro e positivo.");
        }}
        get{
            return this.num;
        }
    }


    public static string ConverterParaBinario(int num)
    {
        string binario = "";

        while (num > 0)
        {
            int valor = num % 2;
            binario = valor.ToString() + binario;
            num = num / 2;
        }

        return binario;
    }
};

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro e positivo para obter sua representação binária:");
        int numero = int.Parse(Console.ReadLine());

        Converter x = new Converter(numero);

        Console.WriteLine("O número decimal " + x.GetConverter() + " em binário é: " + Converter.ConverterParaBinario(x.GetConverter()) + ".");
      }
  }