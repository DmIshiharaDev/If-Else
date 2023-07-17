internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------ Dados de Pagamento ------");
        Console.WriteLine();

        Console.Write("Escreva seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Saldo em conta(INT): R$");
        int saldo = int.Parse(Console.ReadLine());
        Console.Write("Nome do produto");
        string produto = Console.ReadLine();
        Console.Write("Valor do produto(INT): R$");
        int valorProduto = int.Parse(Console.ReadLine());

        int conta = saldo - valorProduto;
        bool aprovado = conta >= valorProduto; 
        bool reprovado = conta <= valorProduto;

        if (aprovado)
        { 
            Console.WriteLine("")
        }
   
    }
}