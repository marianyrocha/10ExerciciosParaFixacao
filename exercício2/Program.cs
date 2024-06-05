// Exercício 2
// Média aritmetica entre 3 valores:

int numeroUm = 0;
int numeroDois = 0;
int numeroTres = 0;
int soma = 0;
double mediaAritmetica = 0;

Console.WriteLine("Digite o primero número: ");
numeroUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numeroDois = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numeroTres = int.Parse(Console.ReadLine());

soma = (numeroUm + numeroDois + numeroTres);
Console.WriteLine("A soma dos três valores é: " + soma);

mediaAritmetica = soma / 3;
Console.WriteLine("Logo, o resultado da média aritmetica será: " + mediaAritmetica); 
