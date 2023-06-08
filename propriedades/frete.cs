using System;
 
public class Program{
    public class Frete{
        private double distancia, peso;
       
        public double Distancia{ get{return distancia;} set {if(value > 0) this.distancia = value;}}
        public double Peso{get{return peso; }set {if(value > 0) this.peso = value;}}
        public double ValorFrete{ get{return 0.01*peso*distancia;}}
        public override string ToString(){ return $"O valor do frete do produto, o qual foi baseado no peso "+Peso+", e na distância " +Distancia+ ", ficou em R$"+ValorFrete.ToString("F2"); }
    };
   



    public static void Main(String[] args) {
        Console.WriteLine("Digite o peso do produto:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a distância a ser percorrida:");
        double distancia = double.Parse(Console.ReadLine());

        Frete frete = new Frete{Peso =peso, Distancia = distancia};

        Console.WriteLine(frete.ToString());
        
    }
}