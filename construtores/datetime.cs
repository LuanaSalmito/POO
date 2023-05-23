using System;
using System.Globalization;

public class Program{

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite seu nome:");
        cpf = Console.ReadLine();

        Console.WriteLine("Digite seu nome:");
        telefone = Console.ReadLine();

        Console.WriteLine("Digite seu nome:");

        nascimento = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

        Paciente paciente = new Paciente(nome, cpf, telefone, nascimento);
        Console.WriteLine(paciente.ToString());

    }

}
public class Paciente{
    private string name;
    private string cpf;
    private string telefone;
    private DateTime nascimento;


    public Paciente(string n, string c, string t, DateTime nasc){
        this.name = n;
        this.cpf = c;
        this.telefone = t;
        this.nascimento = nasc;

    }

    public string Idade(){
        DateTime dataAtual = DateTime.Now;

        int anos = dataAtual.Year - nascimento.Year;
        int meses = dataAtual.Month - nascimento.Month;

        if (dataAtual.Month < nascimento.Month || dataAtual.Month == nascimento.Month && dataAtual.Day < nascimento.Day){
            anos --;
            meses += 12;

        }
        string idade = $"{anos} anos e {meses} meses";
        return idade;
    }
    public override string ToString()
    {
        return $"Nome {nome}.\n CPF: {cpf}.\n Telefone: {telefone}.\n Idade {Idade()}";
    }
}