namespace BibliotecaIMC
{
    public class Calculo
    {
        public double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}