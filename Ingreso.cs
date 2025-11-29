using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_ingreso_laboratorio
{
    public class Ingreso
    {
        public int Idtrabajador { get; set; }
        public string? ZonaIngresada { get; set; } = "";
        public string HoraIngreso { get; set; } = DateTime.Now.ToString("HH:mm");

        public override string ToString() => $"Id: {Idtrabajador} zona: {ZonaIngresada} Hora: ({HoraIngreso})";
    }
}
