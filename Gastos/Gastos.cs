using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project
{
    public class Gastos
    {
        public int IdGasto { get; set; }
        public int IdObra { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string TipoGasto { get; set; }
        public string Monto { get; set; }

        public Gastos()
        {
        }

        public Gastos(int idGasto, int idObra, string tipoGasto, string descripcion, string monto, string fecha)
        {
            IdGasto = idGasto;
            IdObra = idObra;
            Fecha = fecha;
            Descripcion = descripcion;
            TipoGasto = tipoGasto;
            Monto = monto;
        }
    }
}
