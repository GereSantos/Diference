using System;

namespace Exercise__Diference_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula e mostra a diferença entre Produto A * B - C * D

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int dif = 0;

            dif = (A * B - C * D);

            Console.WriteLine("Diferença " + dif );

        }
    }
}
