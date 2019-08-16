using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    public class Aluno
    {
        public int CalcularMedia (int Nota1, int Nota2, int Nota3)
        {
            int Media = (Nota1 + Nota2 + Nota3) / 3;
            return Media;
        }

        public int CalculaFreqencia (int TotalAulas, int TotalFaltas)
        {
            int frequencia = ((TotalAulas - TotalFaltas) *100) / TotalAulas;
            return frequencia;
        }


        public string Situacao (int media, int frequencia)
        {
            if ((media >=7) && (frequencia >= 75))
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado"; 
            }

            Console.ReadKey();
        }
    }
}
