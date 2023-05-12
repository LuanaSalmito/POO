using System;

class Program
{
    public static void Main(string[] args)
    {
        //inicio
        Console.WriteLine("Digite um numero:");
        int numero = int.Parse(Console.ReadLine());


        //Chamada do metodo.
        quadrado(numero);

        //resultado
        Console.WriteLine("O numero digitado foi : {0}", numero);
    }

    //método
    public static void quadrado(int num1)
    {
        int quad = num1 * num1;
        Console.WriteLine(quad.ToString());
    }
}

//Aqui o valor do método vai se alterar apenas quando for chamado o mesmo, o argumento não irá mudar.