using System;

namespace Actividad_Integradora_5_Problema_3
{
    class Veterinaria:IVeterinaria
    {
        public Veterinaria(string nombre, string tipo, DateTime cita, string servicio)
        {
            Nombre = nombre;
            Tipo = tipo;
            Cita = cita;
            Servicio = servicio;
        }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime Cita { get; set; }
        public string Servicio { get; set; }

    }
}
