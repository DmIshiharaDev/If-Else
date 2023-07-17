using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------ Dados da compra ------");
        Console.WriteLine();
        Console.Write("Escreva seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Saldo em conta: R$");
        double saldo = double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("------ Dados do produto ------");
        Console.WriteLine();
        Console.Write("Nome do produto: ");
        string produto = Console.ReadLine();
        Console.Write("Valor do produto: R$");
        double valorProduto = double.Parse(Console.ReadLine());
        Console.WriteLine();

        double conta = saldo - valorProduto;
        bool aprovado = conta >= 0; 

        Console.WriteLine("------ Dados do Pagamento ------");
        Console.WriteLine();

        if (aprovado)
        {
            Console.WriteLine("Parabéns! Sua compra foi aprovada!");
            Console.WriteLine("O valor do saldo restante é de: R$"+conta);
        }
        else 
        {
            Console.WriteLine("Que pena... Seu saldo foi insuficiente para finalizar a compra...");
            Console.WriteLine("Saldo atual é R$" + saldo + " e o valor do produto é R$" + valorProduto);
            Console.WriteLine("Faltou R$" + (conta * -1) + " para finalizar a compra.");
        }

        Console.ReadKey();
    }
}