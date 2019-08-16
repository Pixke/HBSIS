using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_carros.Model
{
    class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public DateTime DateInc { get; set; } = DateTime.Now;

    }
}
