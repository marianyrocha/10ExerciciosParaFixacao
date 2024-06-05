// Exercício 6
// Verificar se um número é par ou ímpar!

int numero = 0;

Console.WriteLine("Digite um número: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número " + numero + " é par!");
}
else
{
    Console.WriteLine("O número " + numero + " é ímpar!");
}