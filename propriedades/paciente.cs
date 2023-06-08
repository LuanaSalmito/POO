using System;

public class Program{

    public class Paciente{
        private string nome, cpf, telefone;
        private DateTime nascimento;
        public string Nome{
            get { return nome;}
            set { if (value != "") nome = value; }
        }
        public string CPF{
            get { return cpf;}
            set { if (value != "") nome = cpf; }
        }
        public string Telefone{
            get { return telefone;}
            set { if (value != "") telefone = value; }
        }
        public DateTime Nascimento{
            get { return nascimento;}
            set { if (value < DateTime.Now) nascimento = value;}
        }
        public string Idade
        {
            get
            {
                DateTime dataAtual = DateTime.Today;
                int idadeEmAnos = dataAtual.Year - nascimento.Year;
                int idadeEmMeses = dataAtual.Month - nascimento.Month;

                if (dataAtual.Month < nascimento.Month || (dataAtual.Month == nascimento.Month && dataAtual.Day < nascimento.Day))
                {
                    idadeEmAnos--;
                    idadeEmMeses = 12 - (nascimento.Month - dataAtual.Month);
                }

                return idadeEmAnos + " anos e " + idadeEmMeses + " meses";
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCPF: {CPF}\nTelefone: {Telefone}\nData de Nascimento: {Nascimento.ToString("dd/MM/yyyy")}\nIdade: {Idade}";
        }


    };






    public static void Main(String[] args) {
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite o telefone:");
        string tel = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento:");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        Paciente x = new Paciente{nome, cpf, telefone, nascimento};

        Console.WriteLine(x.ToString());
    }
}