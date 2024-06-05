// Exercício 10
// Diferentes formas de pagamento!

double valorTotal = 0.00;
int formaPagamento = 0;
double aVista = 0.00;
double cincoParcelas = 0.00;
double dezParcelas = 0.00;
double valorFinal = 0.00;

Console.WriteLine("Digite o valor total da compra:");
valorTotal = double.Parse(Console.ReadLine());

Console.WriteLine("De que forma deseja realizar o pagamento? \n1. À vista; \n2. Parcelar em 3 vezes; \n3. Parcelar em 5 vezes; \n4. Parcelar em 10 vezes");
formaPagamento = int.Parse(Console.ReadLine());

if (formaPagamento == 1)
{
    aVista = valorTotal - (valorTotal * 5) / 100;
    Console.WriteLine("Ao realizar o pagamento à vista, recebe-se um desconto de 5%! \nPortanto, o valor final da compra é R$" + aVista);

}
else
{   
    if(formaPagamento == 2)
    {
        Console.WriteLine("Ao parcelar em 3 vezes, o valor total da compra não sofreu alteração!");
        valorFinal = valorTotal / 3;
        Console.WriteLine("Portanto, o valor final será fracionado em 3 parcelas de R$" + valorFinal);
    }
    else
    {
        if (formaPagamento == 3)
        {
            cincoParcelas = valorTotal + (valorTotal * 2) / 100;
            Console.WriteLine("Ao parcelar em 5 vezes, o valor total da compra sofreu um acréscimo de 2%!");
            valorFinal = cincoParcelas / 5;
            Console.WriteLine("Portanto, o valor final é R$" + cincoParcelas);
            Console.WriteLine("A compra será fracionada em 5 parcelas de R$" + valorFinal);
        }
        else
        {
            if (formaPagamento == 4)
            {
                dezParcelas = valorTotal + (valorTotal * 8) / 100;
                Console.WriteLine("Ao parcelar em 10 vezes, o valor total da compra sofreu um acréscimo de 8%!");
                valorFinal = dezParcelas / 10;
                Console.WriteLine("Portanto, o valor final é R$" + dezParcelas);
                Console.WriteLine("A compra será fracionada em 10 parcelas de R$" + valorFinal);
            }
            else
            {
                Console.WriteLine("Essa opção não existe, digite corretamente!");
            }
        }
    }
    
}