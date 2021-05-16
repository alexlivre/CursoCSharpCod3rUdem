using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {
        private class Conta
        {
            double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo infuficiente.");
                }

                Saldo -= valor;
            }
        }

        public static void Executar()
        {
            var conta = new Conta(1_233.45);

            try
            {
                //int.Parse("abc");

                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
