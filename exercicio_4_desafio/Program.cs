using System;

namespace exercicio_4_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int resultado = 0;
            

            Console.WriteLine("inicio da sequencia de Fibonacci\n");
            Console.WriteLine(resultado);
            Console.WriteLine(a);
            Console.WriteLine(b);

            while(resultado < 500)
            {
                
                resultado = a + b;
                Console.WriteLine(resultado);
                b = a;

                a = resultado;
            }
            Console.WriteLine("finala sequencia de Fibonacci\n");
        }
    }
}
