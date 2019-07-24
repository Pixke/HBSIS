using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_A_Calculadora.Calculadora
{
    public class Calculator

    {
        static void Main(string[] args)
        {
            
            
        }
        public void Calc()
        {
            double num1, num2;
            int resul = 0;

            Console.WriteLine("Digite o Primeiro Número: ");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número: ");

            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while (resul != 5)
            {
                Console.WriteLine("Para Somar Digite - 1");

                Console.WriteLine("Para Subtrair Digite - 2");

                Console.WriteLine("Para Dividir Digite 3");

                Console.WriteLine("Para Multiplicar Digite - 4");

                Console.WriteLine("Para Sair Digite - 5");
                Console.WriteLine(" ");
                Console.WriteLine("EScolha Uma das Opções: ");

                resul = int.Parse(Console.ReadLine());

                if (resul == 1)
                {
                    Console.WriteLine("Soma = {0}", num1 + num2);
                }

                if (resul == 2)
                {
                    Console.WriteLine("Subtração = {0}", num1 - num2);
                }
                if (resul == 3)
                {
                    Console.WriteLine("Divisão = {0}", num1 / num2);
                }
                if (resul == 4)
                {
                    Console.WriteLine("Multiplicação = {0}", num1 * num2);
                }
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
