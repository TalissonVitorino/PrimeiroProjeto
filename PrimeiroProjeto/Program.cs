using System;
using System.Globalization;

namespace PrimeiriProjeto
{
    internal class Program
    {
        static void Main(string[] args) {
            int idade = 32;
            double saldo = 10.35784;
            string nome ="Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reias");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
                + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reias" );
        }
    }
}