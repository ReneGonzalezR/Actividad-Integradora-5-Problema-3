using System;

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
