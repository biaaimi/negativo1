using System;

namespace negativo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
            Console.WriteLine("Você digitou um número negativo.");
            }
            else if (numero > 0)
            {
            Console.WriteLine("Você digitou um número positivo.");
            }
        }
    }
}