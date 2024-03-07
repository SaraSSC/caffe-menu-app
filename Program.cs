using System.Linq.Expressions;

namespace Exercicio3_teste
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, double> menu = new Dictionary<int, double>
        {
            { 100, 2.50 },
            { 101, 3.50 },
            { 102, 4.50 },
            { 103, 2.70 },
            { 104, 3.55 },
            { 105, 1.75 }
        };

            // fazer os pedidos
            while (true)
            {
                Console.Write("Digite o código do produto (ou -1 para encerrar): ");
                int codigoProduto = Convert.ToInt32(Console.ReadLine());

                // Verificar se o usuário deseja encerrar
                if (codigoProduto == -1)
                {
                    Console.WriteLine("Pedido encerrado. Obrigado!");
                    break;
                }

                // Verificar se é válido
                if (menu.ContainsKey(codigoProduto))
                {
                    Console.Write("Digite a quantidade desejada: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    // Valor a pagar
                    double precoUnitario = menu[codigoProduto];
                    double valorItem = quantidade * precoUnitario;

                    Console.WriteLine($"Valor da pagar: {valorItem} euros");
                }
                else
                {
                    Console.WriteLine("Código do produto inválido. Tente novamente.");
                }
            }
        }
    }
}
