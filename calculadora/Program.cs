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
            bool escolheuSair = false;  

            while (!escolheuSair)
            {
                Console.WriteLine("Olá, esta é minha calculadora.");
                Console.WriteLine("1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Potenciação\n6. Raiz\n7. Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine(opcao);
            }
        }
    }
}
