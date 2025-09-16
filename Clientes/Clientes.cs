using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project.Clientes
{
    public class Clientes
    {
        public int IDCliente { get; set; }
        public string NombreApellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }

        public Clientes()
        {
        }

        public Clientes(int idCliente, string nombreApellido, string telefono, string email, string direccion, string cedula)
        {
            IDCliente = idCliente;
            NombreApellido = nombreApellido;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Cedula = cedula;
        }
    }
}
