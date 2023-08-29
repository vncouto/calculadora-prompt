using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        enum Menu { Adicao = 1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            // Manter o código em loop.
            bool escolheuSair = false;  

            while (!escolheuSair)
            {
                Console.WriteLine("Olá, seja bem-vindo ao CALC. Escolha uma das opções:");
                Console.WriteLine("1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Potenciação\n6. Raiz\n7. Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                // Operações
                switch(opcao)
                {
                    case Menu.Adicao:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                // Limpar console.
                Console.Clear();
            }
        }

        // Função, operação de soma.
        static void Soma()
        {
            Console.WriteLine("Soma de dois números.");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // Função, operação de subtração.
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números.");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // Função, operação de multiplicação.
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números.");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // Função, operação de divisão.
        static void Divisao()
        {
            Console.WriteLine("Divisão entre dois números.");
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            float result = (float)num1 / (float)num2;
            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // Função, operação de potenciação.
        static void Potencia()
        {
            Console.WriteLine("Potênciação de um número.");
            Console.WriteLine("Digite a base:");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        // Função, operação de raiz quadrada.
        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada de um número.");

            Console.WriteLine("Digite o número:");
            int num = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(num);

            Console.WriteLine("O resultado é " + result);
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
