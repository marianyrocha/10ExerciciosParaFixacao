// Exercício 9
// Verificar se o aluno ficou para exame!

int prova1 = 0;
int prova2 = 0;
int prova3 = 0;
double mediaProvas = 0.00;
int notaExame = 0;
double mediaFinal = 0.00;

Console.WriteLine("Digite a nota alcançada na primeira prova: ");
prova1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota alcançada na segunda prova: ");
prova2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota alcançada na terceira prova: ");
prova3 = int.Parse(Console.ReadLine());

mediaProvas = (prova1 + prova2 + prova3) / 3;
Console.WriteLine("O resultado da média das provas é: " + mediaProvas);


if (mediaProvas >= 7.0)
{
    Console.WriteLine("O aluno passou na disciplina!");
}
else
{
    Console.WriteLine("O aluno ficou para exame!");
    Console.WriteLine("Digite a nota alcançada no exame: ");
    notaExame = int.Parse(Console.ReadLine());

    mediaFinal = (mediaProvas + notaExame) / 2;
    Console.WriteLine("A média final do aluno é: " + mediaFinal);

    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("O aluno passou na disciplina!");
    }
    else
    {
        Console.WriteLine("O aluno reprovou na disciplina!");
    }
}


