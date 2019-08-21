using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;

namespace WEBAPIRESTFULL.Controllers
{
    public class MathFile
    {
        BibliotecaContextDB BibliotecaContextDB = new BibliotecaContextDB();
        public int QuantidadeDeUsuario()
        {
            return BibliotecaContextDB
                .Usuarios.Count();
        }
    }
}