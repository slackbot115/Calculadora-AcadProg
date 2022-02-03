using System;

namespace Calculadora.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora da Mariana");

            while (true)
            {
                Console.WriteLine("Digite a operacao que deseja realizar: ");
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao\n0 - Sair");
                int op = int.Parse(Console.ReadLine());
                if(op == 0)
                {
                    break;
                }

                Console.WriteLine("Digite o primeiro numero: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                double n2 = double.Parse(Console.ReadLine());

                if (op == 1)
                {
                    double res = n1 + n2;
                    Console.WriteLine("Resultado da operacao: " + res);
                }
                else if (op == 2)
                {
                    double res = n1 - n2;
                    Console.WriteLine("Resultado da operacao: " + res);
                }
                else if (op == 3)
                {
                    double res = n1 * n2;
                    Console.WriteLine("Resultado da operacao: " + res);
                }
                else if (op == 4)
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("Impossivel dividir por 0!");
                    }
                    else
                    {
                        double res = n1 / n2;
                        Console.WriteLine("Resultado da operacao: " + res);
                    }
                }
                else if(op == 0)
                {
                    break;
                }
            }
        }
    }
}
