using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_TarefaBanco
{
    class ContaBancaria
    {

        /* Importante: uma vez que uma conta bancária foi aberta, 
         * o número da conta nunca poderá ser alterado, 
         * contudo o nome do titular pode ser alterado (ex.: pois uma pessoa pode mudar de nome por ocasião de casamento).
         */
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public ContaBancaria(int numConta, string nome, double saldo) : this(numConta, nome)
        {
            Saldo = saldo;
        }

        /* Por fim, o saldo da conta não pode ser alterado livremente e 
         * será preciso haver um mecanismo para proteger isso. 
         * O saldo só aumenta por meio de depósitos, 
         * e só diminuirá por meio de saques. 
         */

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        /*Para cada saque realizado, 
         * o banco cobra uma taxa de R$ 5.00. 
         * Nota: a conta pode ficar com saldo negativo 
         * se o saldo não for suficiente para realizar o saque ou pagar a taxa.
         */

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        /* Realizar um depósito um saque, 
         * sempre mostrando os dados da conta após cada operação.
         */
        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
