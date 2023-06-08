using System;

public class Program{
  
  public class Retangulo{
    private double b, h;

    public double Base{
        get { return b; }
        set { if(value > 0) b = value;}
    }
    public double Altura{
        get { return h; }
        set { if(value > 0) h = value;}
    }
    public double Area{
        get{ return b * h; }
    }
    public double Diagonal{
        get{return Math.Sqrt(b*b + h*h);}
    }
    public override string ToString() { 
        return $"O retângulo de base "+Base+", e altura de "+ Altura+", tem a diagonal de: "+Diagonal.ToString("F2")+", e área de: "+Area+".";}

};
    public static void Main(String[] args) {
        Console.WriteLine("Digite a base do retagulo:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do retagulo:");
        double h = double.Parse(Console.ReadLine());
        Retangulo ret = new Retangulo{Base = b, Altura = h};

        Console.WriteLine(ret.ToString());

    }
}