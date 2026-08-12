BibliotecaIMC

Biblioteca em C# que realiza o cálculo do Índice de Massa Corporal (IMC).

Descrição

A BibliotecaIMC é uma DLL desenvolvida em C# que possui um método para calcular o IMC a partir do peso e da altura de uma pessoa.

Como utilizar

Adicione a referência da DLL BibliotecaIMC.dll ao seu projeto C#.

Depois, importe o namespace:

using BibliotecaIMC;

Crie um objeto da classe Calculo:

Calculo calculo = new Calculo();

Utilize o método CalcularIMC informando o peso em quilogramas e a altura em metros:

double imc = calculo.CalcularIMC(70, 1.75);

O resultado será:

22,86
Método disponível
CalcularIMC
public double CalcularIMC(double peso, double altura)

Parâmetros:

peso: peso da pessoa em quilogramas.
altura: altura da pessoa em metros.

Retorno:

Retorna o valor calculado do IMC.

Fórmula
IMC = peso / (altura × altura)
Exemplo
using BibliotecaIMC;

Calculo calculo = new Calculo();

double resultado = calculo.CalcularIMC(70, 1.75);

Console.WriteLine($"IMC: {resultado:F2}");

Saída:

IMC: 22,86
Tecnologias
C#
.NET
Visual Studio
Biblioteca de Classes (DLL)
Autor

Projeto desenvolvido para a disciplina de POO 2.
