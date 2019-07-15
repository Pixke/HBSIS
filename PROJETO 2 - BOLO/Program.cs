using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCICIO_2___BOLO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" OLÁ, VAMOS ENSINAR UMA DELICIOSA RECEITA DE BOLO");
            Thread.Sleep(500);
            Console.WriteLine("   É SO SEGUIR OS PASSOS, QUE NÃO TEM ERRO.");
            Thread.Sleep(500);
            Console.WriteLine("   UMA DELÍCIA");
            Thread.Sleep(500);
            Console.WriteLine("   VAMOS LÁ.");
            Thread.Sleep(500);
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("                                                 ");
            Console.WriteLine("          ENTER PARA PROSEGUIR.");
            Console.WriteLine("_________________________________________________");
            Console.ReadKey();

            IngredientesMassa();
            Thread.Sleep(700);
            IgredientesCobertura();
            Thread.Sleep(700);
            PreparoMassa();
            Thread.Sleep(700);
            PreparoCobertura();

        }
        public static void IngredientesMassa()
        {
            Console.WriteLine("                                                  ");
            Console.WriteLine("     INGREDIENTES PARA A MASSA");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine(" 3x  CENOURAS MÉDIAS RASPADAS E PICADAS");
            Thread.Sleep(250);
            Console.WriteLine(" 3x  OVOS");
            Thread.Sleep(250);
            Console.WriteLine(" 1x  XÍCARA DE ÓLEO");
            Thread.Sleep(250);
            Console.WriteLine(" 2x  XÍCARAS DE AÇÚCAR");
            Thread.Sleep(250);
            Console.WriteLine(" 2x  XÍCARAS DE FARINHA DE TRIGO");
            Thread.Sleep(250);
            Console.WriteLine(" 1x  COLHER (SOPA) DE FERMENTO EM PÓ");
            Thread.Sleep(250);
            Console.WriteLine(" 1x  PITADA DE SAL");

        }
        public static void IgredientesCobertura()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("                                                  ");
            Console.WriteLine("     INGREDIENTES PARA COBERTURA");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Thread.Sleep(250);
            Console.WriteLine(" 5x COLHERES (SOPA) DE AÇÚCAR");
            Thread.Sleep(250);
            Console.WriteLine(" 3x COLHERES (SOPA) DE CHOCOLATE EM PÓ");
            Thread.Sleep(250);
            Console.WriteLine(" 2x COLHERES (SOPA) DE MANTEIGA");
            Thread.Sleep(250);
            Console.WriteLine(" 2x COLHERES (SOPA) DE LEITE");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("                                                  ");

        }
        public static void PreparoMassa()
        {
            Console.WriteLine("            MODO DE PREPARO DA MASSA:");
            Console.WriteLine("                                                  ");
            Thread.Sleep(250);
            Console.WriteLine(" O MODO DE PREPARO DO BOLO É MUITO FÁCIL,");
            Console.WriteLine(" BASTA BATER NO LIQUIDIFICADOR TODOS OS INGREDIENTES,");
            Console.WriteLine(" ACRESCENTANDO A FARINHA AOS POUCOS.");
            Console.WriteLine("                                                  ");
            Thread.Sleep(250);
            Console.WriteLine(" DEPOIS UNTE E ENFARINHE UMA FORMA E DESPEJE A MASSA NELA.");
            Console.WriteLine(" ASSE EM FORNO MÉDIO POR CERCA DE 40 MINUTOS. ");
            Console.WriteLine(" TIRE DO FORNO, ESPERE AMORNAR E DESENFORME.");

            Console.WriteLine("_________________________________________________");
        }
        public static void PreparoCobertura()
        {
            Console.WriteLine("            PREPARO DA COBERTURA:   ");
            Console.WriteLine("                                                  ");
            Thread.Sleep(250);
            Console.WriteLine(" ENQUANTO O BOLO ASSA, EM UMA PANELA, COLOQUE TODOS OS");
            Console.WriteLine(" INGREDIENTES DA COBERTURA E MEXA BEM ATÉ LEVANTAR FERVURA.");
            Console.WriteLine(" DEPOIS ESPALHE SOBRE O BOLO AINDA QUENTE E QUANDO ESFRIAR VAI FORMAR UMA CASQUINHA.");
            Console.WriteLine("                                                  ");
            Thread.Sleep(250);
            Console.WriteLine(" SIMPLES, NÃO? ESPERO QUE GOSTEM!");
            Console.WriteLine("_________________________________________________");
            Thread.Sleep(1000);
            Console.WriteLine("     PRESSIONE QUALQUER TECLA PARA FECHAR!   ");

            Console.ReadKey();

        }
    }
}
