// Exercíco 4
// Reajuste salarial!

string nomeFuncionario;
double salarioAtual = 0.00;
double valorAumento = 0.00;
double salarioReajustado = 0.00;

Console.WriteLine("Digite o nome do funcionário: ");
nomeFuncionario = Console.ReadLine();

Console.WriteLine("Digite o valor do salário atual: ");
salarioAtual = double.Parse(Console.ReadLine());

valorAumento = (salarioAtual * 8.75)/100;
Console.WriteLine("O valor da taxa do reajuste salarial é R$" + valorAumento);

salarioReajustado = salarioAtual + valorAumento;
Console.WriteLine(nomeFuncionario + " recebe, atualmente, o salário de R$" + salarioAtual + "\nCom o reajuste salarial, passará a receber R$" + salarioReajustado);