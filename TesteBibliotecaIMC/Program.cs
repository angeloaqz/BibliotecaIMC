using BibliotecaIMC;

class Program
{
    static void Main(string[] args)
    {
        Calculo calculo = new Calculo();

        Console.Write("Digite seu peso em kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = calculo.CalcularIMC(peso, altura);

        Console.WriteLine();
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        Console.ReadKey();
    }
}