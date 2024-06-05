// Exercício 3
// Sistema de gerencimamento de vendas!

string codigoProduto;
string nomeProduto;
double valorUnitario = 0.00;
int quantidadeComprada = 0;
double valorTotal = 0.00;

Console.WriteLine("Digite o código do produto: ");
codigoProduto = Console.ReadLine();

Console.WriteLine("Digite o nome do produto: ");
nomeProduto =  Console.ReadLine();

Console.WriteLine("Digite o valor unitário do produto: ");
valorUnitario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade que deseja comprar: ");
quantidadeComprada = int.Parse(Console.ReadLine());

valorTotal = valorUnitario * quantidadeComprada; 
Console.WriteLine("O valor total da compra é R$" + valorTotal);

Console.WriteLine("Dados da compra: \nCódigo do produto: " + codigoProduto + "\nNome do produto: " + nomeProduto + "\nValor unitário: R$" + valorUnitario + "\nQuantidade comprada: " + quantidadeComprada + "\nValor total: R$" + valorTotal);
