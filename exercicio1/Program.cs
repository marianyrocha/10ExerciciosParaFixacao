// Exercício 1
// Soma entre 4 valores!

int soma = 0;
int numeroUm = 0;
int numeroDois = 0;
int numeroTres = 0;
int numeroQuatro = 0;

Console.WriteLine("Digite o primeiro número: ");
numeroUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numeroDois = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numeroTres = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto número: ");
numeroQuatro = int.Parse(Console.ReadLine());

soma = numeroUm + numeroDois + numeroTres + numeroQuatro;
Console.WriteLine("O resultado final da soma dos quatro valores é: " + soma); 