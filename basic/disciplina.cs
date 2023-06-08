using System; 

public class Disciplina{
  private string name;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  private int notaFinal;

  public Disciplina(string nome){
    name = nome;
  }
  
  public void SetNota1(int n1){
    nota1=n1;
  }
  
  public void SetNota2(int n2){
    nota2=n2;
  }
  
  public void SetNota3(int n3){
    nota3=n3;
  }
  
  public void SetNota4(int n4){
    nota4=n4;
  }
  
  public void SetNotaFinal(int nf){
    notaFinal = nf;
  }

  public int GetNota1(){
    return nota1;
  }
  
  public int GetNota2(){
    return nota2;
  }
  
  public int GetNota3(){
    return nota3;
  }
  
  public int GetNota4(){
    return nota4;
  }
  
  public int GetNotaFinal(){
    return notaFinal;
  }
  
  public int CalcMediaParcial(){
    int mediaParc = ((nota1*2)+(nota2*2)+(nota3*3)+(nota4*3))/10;
    return mediaParc;
  }
  
  public int CalcMediaFinal(){
    int mediaFim;
    int mediaPar =  CalcMediaParcial();

    if(mediaPar < 60 && notaFinal >=0){
      mediaFim = (mediaPar+notaFinal)/2;
    }
    else{
      mediaFim = mediaPar;
    }

    return mediaFim;
  }
  
}

public class Program {

  public static void Main(string[] args) {

    Console.WriteLine("Digite o nome da disciplina: ");
    string nome = Console.ReadLine();
    Disciplina x = new Disciplina(nome);
    
    Console.WriteLine("Digite a nota do primeiro bimestre: ");
    int nota1 = int.Parse(Console.ReadLine());
    x.SetNota1(nota1);
    
    Console.WriteLine("Digite a nota do segundo bimestre: ");
    int nota2 = int.Parse(Console.ReadLine());
    x.SetNota2(nota2);
    
    Console.WriteLine("Digite a nota do terceiro bimestre: ");
    int nota3 = int.Parse(Console.ReadLine());
    x.SetNota3(nota3);
    
    Console.WriteLine("Digite a nota do quarto bimestre: ");
    int nota4 = int.Parse(Console.ReadLine());
    x.SetNota4(nota4);

    Console.WriteLine("Digite a nota da prova final: ");
    int notaFinal = int.Parse(Console.ReadLine());
    x.SetNotaFinal(notaFinal);

    Console.WriteLine("A disciplina é: "+ nome);
    Console.WriteLine("A nota do primeiro bimestre é: "+x.GetNota1());
    Console.WriteLine("A nota do segundo bimestre é: "+x.GetNota2());
    Console.WriteLine("A nota do terceiro bimestre é: "+x.GetNota3());
    Console.WriteLine("A nota do quarto bimestre é: "+x.GetNota4());
    Console.WriteLine("A média parcial é: "+x.CalcMediaParcial());
    Console.WriteLine("A média final é: "+x.CalcMediaFinal());
  }
}
