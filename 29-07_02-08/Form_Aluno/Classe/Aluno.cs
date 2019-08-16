using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Aluno.Classe
{
    public class Aluno
    {
        public string Nome_Aluno { get; set; }
        public int Idade { get; set; }

        public DateTime DatInc { get; set; } = DateTime.Now;
    }

    
}
