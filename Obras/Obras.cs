using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAHO_Project
{
    public class Obras
    {
        public int IdObra { get; set; }
        public int IDCliente { get; set; }
        public string NombreObra { get; set; }
        public string TipoObra { get; set; }
        public string Ubicacion { get; set; }
        public string MetrosCuadrados { get; set; }
        public string Presupuesto { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Recordatorio { get; set; }
        public string Estado { get; set; } = "Agendado";
        public int IdUsuario { get; set; }



        public Obras()
        {
        }

        public Obras(int idobra, int idCliente, string nombreObra, string tipoobra, string ubicacion, string metroscuadrados, string presupuesto, string fechaInicio, string fechaFinal, string recordatorio, string estado, int idUsuario)
        {
            IdObra = idobra;
            IDCliente = idCliente;
            NombreObra = nombreObra;
            TipoObra = tipoobra;
            Ubicacion = ubicacion;
            MetrosCuadrados = metroscuadrados;
            Presupuesto = presupuesto;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;           
            Recordatorio = recordatorio;
            Estado = estado;
            IdUsuario = idUsuario;
        }
    }
}
