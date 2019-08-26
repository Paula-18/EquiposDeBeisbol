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

            Equipo gatos =
                new Equipo("Gatos");
            Equipo perros =
                new Equipo("Perros");

            equipos.Add(gatos);
            equipos.Add(perros);

            Jugador caro = new Jugador("Carolina");
            Jugador ana = new Jugador("Ana");
            Jugador josefina = new Jugador("Josefina");
            Jugador eli = new Jugador("Eli");
            Jugador maria = new Jugador("María");
            Jugador karla = new Jugador("Karla");
            Jugador blanca = new Jugador("Blanca");
            Jugador dani = new Jugador("Daniela");
            Jugador ale = new Jugador("Alejandra");


            Jugador juan = new Jugador("Juan");
            Jugador jose = new Jugador("José");
            Jugador jesus = new Jugador("Jesús");
            Jugador luis = new Jugador("Luis");
            Jugador carlos = new Jugador("Carlos");
            Jugador andres = new Jugador("Andrés");
            Jugador rene = new Jugador("René");
            Jugador fer = new Jugador("Fernando");
            Jugador pablo = new Jugador("Pablo");

        }
    }
}
