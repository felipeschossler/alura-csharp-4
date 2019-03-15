using System;

namespace ByteBank
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque de "+ valorSaque + " com saldo de " +saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
