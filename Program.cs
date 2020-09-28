using System;
using System.Reflection;
using System.Resources;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            ContaCorrente conta1 = new ContaCorrente(200.00);

            Console.WriteLine("Por favor, informe seu nome:");
            conta1.Titular = Console.ReadLine();

            Console.WriteLine($"\nOlá, {conta1.Titular} seja bem vindo(a) ao Banco XYZ");

            while (opcao != 4)
            {
                Console.WriteLine("\nPor favor, digite a opção desejada:");
                Console.WriteLine("1 - Saldo \n2 - Saque \n3 - Deposito \n4 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Saldo atual: R$ {conta1.ConsultarSaldo():F2}");
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor para saque:");
                        conta1.Saque(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Saldo atual: R$ {conta1.ConsultarSaldo():F2}");
                        break;
                    case 3:
                        Console.WriteLine("Informe o valor para deposito:");
                        conta1.Deposito(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Saldo atual: R$ {conta1.ConsultarSaldo():F2}");
                        break;
                }

            }
            Console.WriteLine("Fim!");
        }
    }
}
