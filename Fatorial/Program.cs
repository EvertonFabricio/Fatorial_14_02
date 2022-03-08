using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat = 1, n = 0;
            Console.WriteLine("Digite um número inteiro maior que zero para calcularmos seu fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            n = numero;


            if (n == 0)
                Console.WriteLine("\nO fatorial do número 0 é igual a 1.");
            else if (n > 0)
            {
                do
                {
                    fat = fat * n;
                    n = n - 1;
                }
                while (n > 0);

                Console.WriteLine($"\nO fatorial do número {numero} é igual a {fat}.");
            }
            else
            {
                Console.WriteLine("Tente novamente digitando um número positivo.");
            }
           
        }
    }
}
