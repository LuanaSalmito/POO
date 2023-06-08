using System;

public class Program {
    public class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public static void Main(string[] args) {
        Estudante[] quartos = new Estudante[10];

        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"\nAluguel #{i + 1}");

            Console.Write("Nome do estudante: ");
            string nome = Console.ReadLine();

            Console.Write("Email do estudante: ");
            string email = Console.ReadLine();

            Console.Write("Número do quarto (0 a 9): ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            quartos[numeroQuarto] = new Estudante { Nome = nome, Email = email };
        }

        Console.WriteLine("\nRelatório de ocupações do pensionato:");

        for (int i = 0; i < 10; i++) {
            if (quartos[i] != null) {
                Console.WriteLine($"Quarto {i}: {quartos[i].Nome}, {quartos[i].Email}");
            }
        }
    }
}