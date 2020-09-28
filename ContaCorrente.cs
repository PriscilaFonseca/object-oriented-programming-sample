using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CaixaEletronico
{
    class ContaCorrente
    {
        private double Saldo;
        public string Titular;

        public ContaCorrente(double valor)
        {
            this.Saldo = valor;
        }

        public double Saque(double valor)
        {
            if (Saldo >= valor)
            {
                return this.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return this.Saldo;
            }

        }
        public double Deposito(double valor)
        {
            return this.Saldo += valor;
        }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }
    }
}
