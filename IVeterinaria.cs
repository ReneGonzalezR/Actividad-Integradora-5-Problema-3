using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_5_Problema_3
{
    interface IVeterinaria
    {
        string Nombre { get; set; }
        string Tipo { get; set; }
        DateTime Cita { get; set; }
        string Servicio { get; set; }
    }
}
