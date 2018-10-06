using System;

namespace SaldoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Poupanca Carlos = new Poupanca(2000M);
            Poupanca Guilherme = new Poupanca(3000M);
                        
            Console.WriteLine("Bem vindo");
            Console.WriteLine("A taxa de juros atual é de 4%");
            Poupanca.AlterataxadeJuros(0.04);
            Console.WriteLine("Seu saldo é de:" + Carlos.CalcularJurosMensal());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Bem vindo");
            Console.WriteLine("A taxa de juros atual é de 4%");
            Console.WriteLine("Seu saldo é de:" + Guilherme.CalcularJurosMensal());
            Console.ReadKey();
            Console.Clear();

            //Alterar taxa para 5%
            Console.WriteLine("Bem vindo");
            Console.WriteLine("A taxa de juros atual é de 5%");
            Poupanca.AlterataxadeJuros(0.05);
            Console.WriteLine("Seu saldo é de:" + Carlos.CalcularJurosMensal());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Bem vindo");
            Console.WriteLine("A taxa de juros atual é de 5%");
            Console.WriteLine("Seu saldo é de:" + Guilherme.CalcularJurosMensal());
            Console.ReadKey();








        }
    }
}
