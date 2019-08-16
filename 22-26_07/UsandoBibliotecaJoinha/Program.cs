using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinha;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            new AquiMostraJoinha().MetodoInicialMostraJoinha();
            Console.ReadKey();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);
            Console.ReadKey();

            new AquiMostraJoinha().MetodoDoisPontoZero(false);
            Console.ReadKey();

            //Operação pesada como leitura e gravação na memoria
            var outroCaraParaRealizaroTeste = new AquiMostraJoinha().TesteUmOperadorLegal();
            
            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizaroTeste.Length;
            
            //Nossa 'for' agora está mais rápida
            for (int i = 0; i < outroCaraParaRealizaroTeste.Length; i++)
            {
                Console.WriteLine(outroCaraParaRealizaroTeste[i]);
            }


            Console.ReadKey();
        }
    }
}
