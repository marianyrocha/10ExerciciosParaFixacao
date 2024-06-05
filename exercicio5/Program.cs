// Exercício 5
// 10% de desconto no preço de produtos!

double preçoAtual = 0.00;
double taxaDesconto = 0.00;
double preçoFinal = 0.00;

Console.WriteLine("Digite o valor atual do produto:");
preçoAtual = double.Parse(Console.ReadLine());

taxaDesconto = (preçoAtual * 10) / 100;
Console.WriteLine("O produto recebeu o desconto R$" + taxaDesconto);

preçoFinal = preçoAtual - taxaDesconto;
Console.WriteLine("O preço atual do produto é R$" + preçoAtual + ".\nCom o desconto de 10%, passará a custar R$" + preçoFinal);