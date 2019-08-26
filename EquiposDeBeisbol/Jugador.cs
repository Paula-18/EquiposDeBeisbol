using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposDeBeisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Sin Asignar";
            Numero = "Sin Asignar";
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Numero = "Sin Asignar";
        }
    }
}
