using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposDeBeisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public List<Jugador> Jugadoress { get; set; }

        public Equipo()
        {
            Nombre = "Sin Asignar";
            CiudadDeOrigen = "Sin Asignar";
            Entrenador = "Sin Asignar";
            Jugadores = "Sin Asignar";
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            CiudadDeOrigen = "Sin Asignar";
            Entrenador = "Sin Asignar";
            Jugadoress = new List<Jugador>();
        }
    }
}
