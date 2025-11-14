using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UsuarioNombre { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }

        public Usuario(int id, string usuarioNombre, string nombre, string puesto, string email, byte[] foto)
        {
            IdUsuario = id;
            UsuarioNombre = usuarioNombre;
            Nombre = nombre;
            Puesto = puesto;
            Email = email;
            Foto = foto;
        }

        public Usuario(int id, string nombre, string puesto, string email, byte[] foto)
        {
            IdUsuario = id;
            Nombre = nombre;
            Puesto = puesto;
            Email = email;
            Foto = foto;
        }

        public Usuario(int id, string nombre, string email, byte[] foto)
        {
            IdUsuario = id;
            Nombre = nombre;
            Email = email;
            Foto = foto;
        }

        public Usuario()
        {
        }
    }
}
