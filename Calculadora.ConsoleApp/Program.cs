using System;
using System.Collections.Generic;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora da Mariana");

            List<double> historico = new List<double>();
            while (true)
            {
                Console.WriteLine("Digite a operacao que deseja realizar: ");
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao\n5 - Histórico\n0 - Sair");
                try
                {
                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        double n2 = double.Parse(Console.ReadLine());
                        double res = n1 + n2;
                        Console.WriteLine("Resultado da operacao: " + Math.Round(res, 2));
                        historico.Add(res);
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        double n2 = double.Parse(Console.ReadLine());
                        double res = n1 - n2;
                        Console.WriteLine("Resultado da operacao: " + Math.Round(res, 2));
                        historico.Add(res);
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        double n2 = double.Parse(Console.ReadLine());
                        double res = n1 * n2;
                        Console.WriteLine("Resultado da operacao: " + Math.Round(res, 2));
                        historico.Add(res);
                    }
                    else if (op == 4)
                    {
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        double n2 = double.Parse(Console.ReadLine());
                        if (n2 == 0)
                        {
                            Console.WriteLine("Impossivel dividir por 0!");
                        }
                        else
                        {
                            double res = n1 / n2;
                            Console.WriteLine("Resultado da operacao: " + Math.Round(res, 2));
                            historico.Add(res);
                        }
                    }
                    else if (op == 5)
                    {
                        if (historico.Count > 0)
                        {
                            Console.WriteLine("Histórico de resultados: ");
                            for (int i = 0; i < historico.Count; i++)
                            {
                                Console.WriteLine(i + ": " + historico[i]);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Histórico vazio...");
                            Console.WriteLine();
                        }
                        
                    }
                    else if (op == 0)
                    {
                        Console.WriteLine("Fechando o programa...\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida, digite novamente...\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Ocorreu um erro, digite novamente...\n");
                }

                
            }
        }
    }
}
