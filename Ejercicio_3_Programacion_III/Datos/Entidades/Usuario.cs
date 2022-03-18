using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, string clave, bool estaActivo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
            EstaActivo = estaActivo;
        }
    }
}
