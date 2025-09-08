using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }

        public Usuario(string nombre, string puesto, string email)
        {
            Nombre = nombre;
            Puesto = puesto;
            Email = email;
        }
    }
}
