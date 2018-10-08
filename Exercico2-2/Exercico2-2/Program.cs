using System;

namespace Exercico2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente A = new Cliente(2000, 200, 300, 400, 2000);

            Console.WriteLine(A.CalcularNovoSaldo());

            A.AtualizarSaldo();

            if(A.ultrapassarLimite())
            {
                Console.WriteLine("Limite de credito excedido!");

            }


        }
    }
}
