// Exercício 8
// Verificar se é multiplo de 3 ou 7!

int multiplo = 0;

Console.WriteLine("Digite um número:");
multiplo = int.Parse(Console.ReadLine());

if (multiplo % 3 == 0 & multiplo % 7 == 0)
{
    Console.WriteLine("O número " + multiplo + " é multiplo de 3 e 7!");
}
else
{
    if (multiplo % 3 == 0)
    {
        Console.WriteLine("O número " + multiplo + " é multiplo de 3!");
    }
    else
    {
        if (multiplo % 7 == 0)
        {
            Console.WriteLine("O número " + multiplo + " é multiplo de 7!");
        }
        else
        {
            Console.WriteLine("O número " + multiplo + " não é multiplo de 3 nem 7!");
        }
    }

}

