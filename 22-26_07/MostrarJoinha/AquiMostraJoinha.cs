using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinha
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// Será que é sexta hoje?
        /// </summary>
        public void MetodoInicialMostraJoinha()
        {
            Console.WriteLine("Aqui Iniciamos o Joinha.");
        }

        public void MetodoDoisPontoZero (bool eQuinta)
        {
            if (eQuinta)
            {
                Console.WriteLine("Carai Mermão");

            }
            else
            {
                Console.WriteLine("AiAi");
            }

        }
        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste1", "Teste2" };    
        }
    }
}
