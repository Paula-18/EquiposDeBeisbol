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
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Nombre = "Equipo Nuevo";
            CiudadDeOrigen = "Sin Ciudad";
            Entrenador = "Sin Entrenador";
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            CiudadDeOrigen = "Sin Ciudad";
            Entrenador = "Sin Entrenador";
            Jugadores = new List<Jugador>();
        }
    }
}
