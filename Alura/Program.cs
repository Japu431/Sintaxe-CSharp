using System;

namespace Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = (int)10.0000;
            Console.WriteLine(a);

            string cursosProgramacao = @"
- .NET 
- Java
- Javascript";

            Console.WriteLine(cursosProgramacao);

            int idadeJoao = 17;
            bool acompanhado = false;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade pode entrar!!");
            }
            else if (acompanhado == true)
            {
                Console.WriteLine("Menor de Idade , porém acompanhado");
            }
            else
            {
                Console.WriteLine("Não pode entrar...");
            }

            int op = 1;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Opção 01");
                    break;
                case 2:
                    Console.WriteLine("Opção 02");
                    break;
                case 3:
                    Console.WriteLine("Opção 03");
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
                    int quantosMeses = 1;
                    double valorInvestido = 1000;

                    while(quantosMeses <= 12)
                    {
                        valorInvestido = valorInvestido + valorInvestido * 0.0036;
                        Console.WriteLine(valorInvestido);
                        quantosMeses++;
                    }

                    for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                    {
                        valorInvestido = valorInvestido * 1.0036;
                        Console.WriteLine("Após " + contadorMes + "meses , você terá R$" + valorInvestido);
                    }


                
            for(int contador = 1; contador <= 10; contador++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contador)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }

        

            Console.ReadLine();
        }
    }
}
