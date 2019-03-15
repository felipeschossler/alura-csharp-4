using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente con = new ContaCorrente(200, 200334);
            }
            catch (ArgumentException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.ParamName);
            }

            Console.ReadLine();
        }
        //end main method

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                Console.WriteLine("O resultado da divisão é: " + numero / divisor);
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Erro no número "+ numero +" e divisor "+ divisor);
                throw;
            }
        }

    }
}
