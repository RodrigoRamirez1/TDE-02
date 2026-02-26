// See https://aka.ms/new-console-template for more information
Console.WriteLine("TDE-02 - Calculadora");

Console.WriteLine("Informe o primeiro número: ");
double primeiroNumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
double segundoNumero = Convert.ToDouble(Console.ReadLine());

double adicao = primeiroNumero + segundoNumero;
double subtracao = primeiroNumero - segundoNumero;
double multiplicacao = primeiroNumero * segundoNumero;
double divisao = primeiroNumero/segundoNumero;

//Concatenação
Console.WriteLine("A soma dos dois número é: " + adicao);

//Interpolação
Console.WriteLine($"A subtração entre os dois números é: {subtracao}");

//Placeholders
Console.WriteLine(string.Format("A multiplicação entre os dois números é: {0}", multiplicacao));
Console.WriteLine(string.Format("A divisão entre os dois números é: {0}", divisao));