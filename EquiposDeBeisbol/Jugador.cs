﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposDeBeisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Jugador()
        {
            Nombre = "Sin Asignar";
            Numero = 0;
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
