using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            char opcao;
            double valor = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("---------- BANCO ----------\n\n");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Saque");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("3 - Saldo");
                Console.Write("\n\nOpção: ");
                opcao = Convert.ToChar(Console.ReadLine());
                switch (opcao)
                {
                    case '0':
                        Console.WriteLine("\nBye\n\nPressione qualquer tecla para sair.");
                        Console.ReadKey();
                        break;
                    case '1':
                        Console.Clear();
                        Console.WriteLine("\n--------- Saque ---------\n");
                        Console.Write("Valor: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Saque(valor);
                        Console.WriteLine("\n\nSaque efetuado com sucesso!");
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("\n-------- Depósito --------\n");
                        Console.Write("Valor: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Deposito(valor);
                        Console.WriteLine("\n\nDepósito efetudo com sucesso");
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("\n--------- Saldo ---------\n");
                        Console.WriteLine($"Saldo: {conta.MostraSaldo()}\n");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != '0');
        }
    }
}
