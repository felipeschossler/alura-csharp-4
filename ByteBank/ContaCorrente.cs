using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            if (valor < 0)
            {
                throw new ArgumentException("Tentativa de valor de saque negativo.");
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                throw new ArgumentException("Tentativa de valor de saque negativo.");
            }

            Sacar(valor);
            contaDestino.Depositar(valor);

        }
    }
}
