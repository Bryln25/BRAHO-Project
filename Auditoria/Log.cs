using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project.Auditoria
{
    public class Log
    {
        public int IdAuditoria { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
        public string Fecha { get; set; }
        public string Equipo { get; set; }

        public Log()
        {
        }

        public Log(int Idauditoria, string usuario, string accion, string detalle, string fecha, string equipo)
        {
            IdAuditoria = Idauditoria;
            Usuario = usuario;
            Accion = accion;
            Detalle = detalle;
            Fecha = fecha;
            Equipo = equipo;
        }
    }
}
