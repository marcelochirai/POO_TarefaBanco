using System;
using System.Globalization;

namespace POO_TarefaBanco
/*Em um banco, para se cadastrar uma conta bancária, é necessário informar:
 * o número da conta, 
 * o nome do titular da conta, e 
 * o valor de depósito inicial que o titular depositou ao abrir a conta.
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            
            Console.Write("Informe o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular da conta: ");
            string nome = Console.ReadLine();

            /* Um valor de depósito inicial,  é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, 
             * o depósito inicial não será feito e 
             * o saldo inicial da conta será, naturalmente, zero.
             */
            Console.Write("Haverá um depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Informe o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numConta, nome, depInicial);
            }

            else
            {
                conta = new ContaBancaria(numConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Informações da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(quantia);
            Console.WriteLine("Informações da conta atualizadas:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Informações da conta atualizadas:");
            Console.WriteLine(conta);

        }
    }
}
