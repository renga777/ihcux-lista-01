
using System;

class Program
{
    static void Main()
    {
        int codigo = 0;
        int quantidade = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 1 de 3] Seleção do Produto");
            Console.WriteLine("Digite o código do produto (1 a 10):");
            Console.WriteLine("Digite 'cancelar' para sair.");

            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (!int.TryParse(entrada, out codigo))
            {
                Console.WriteLine("Entrada inválida. Digite apenas números.");
                Console.ReadLine();
                continue;
            }

            if (codigo < 1 || codigo > 10)
            {
                Console.WriteLine($"Código {codigo} não encontrado. Nossos códigos vão de 1 a 10. Tente novamente.");
                Console.ReadLine();
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 2 de 3] Quantidade");
            Console.WriteLine("Digite a quantidade:");
            Console.WriteLine("Digite 'voltar' para retornar ou 'cancelar' para sair.");

            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (entrada == "voltar")
            {
                Main();
                return;
            }

            if (!int.TryParse(entrada, out quantidade))
            {
                Console.WriteLine("Quantidade inválida. Digite um número.");
                Console.ReadLine();
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 3 de 3] Confirmação");
            Console.WriteLine($"Produto: {codigo}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.WriteLine("Digite 'confirmar', 'voltar' ou 'cancelar'");

            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (entrada == "voltar")
            {
                Main();
                return;
            }

            if (entrada == "confirmar")
            {
                Console.WriteLine("Pedido realizado com sucesso!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Opção inválida.");
            Console.ReadLine();
        }
    }
}