using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposDeBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo azul =
                new Equipo("Azul");

            azul.Entrenador = "Pedro";
            azul.CiudadDeOrigen = "Ciudad Obregón";

            azul.Jugadores.Add(new Jugador("Jugador 1", 18));
            azul.Jugadores.Add(new Jugador("Jugador 2", 21));
            azul.Jugadores.Add(new Jugador("Jugador 3", 32));
            azul.Jugadores.Add(new Jugador("Jugador 4", 44));
            azul.Jugadores.Add(new Jugador("Jugador 5", 52));
            azul.Jugadores.Add(new Jugador("Jugador 6", 26));
            azul.Jugadores.Add(new Jugador("Jugador 7", 75));
            azul.Jugadores.Add(new Jugador("Jugador 8", 28));
            azul.Jugadores.Add(new Jugador("Jugador 9", 39));

            Equipo negro =
                new Equipo("Negro");
            negro.Entrenador = "Juan";
            negro.CiudadDeOrigen = "Mexicali";

            negro.Jugadores.Add(new Jugador("Jugador 1", 23));
            negro.Jugadores.Add(new Jugador("Jugador 2", 45));
            negro.Jugadores.Add(new Jugador("Jugador 3", 86));
            negro.Jugadores.Add(new Jugador("Jugador 4", 83));
            negro.Jugadores.Add(new Jugador("Jugador 5", 13));
            negro.Jugadores.Add(new Jugador("Jugador 6", 19));
            negro.Jugadores.Add(new Jugador("Jugador 7", 41));
            negro.Jugadores.Add(new Jugador("Jugador 8", 74));
            negro.Jugadores.Add(new Jugador("Jugador 9", 54));

            equipos.Add(azul);
            equipos.Add(negro);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre + " de " + equipo.CiudadDeOrigen);
                Console.WriteLine("Lista de los jugadores: ");
                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" + jugador.Nombre + " " + jugador.Numero);
                }
            }

            Console.Read();
        }
    }
}
