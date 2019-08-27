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
            Equipo negro =
                new Equipo("Negro");

            equipos.Add(azul);
            equipos.Add(negro);

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

            azul.Jugadoress.Add(caro);
            azul.Jugadoress.Add(ana);
            azul.Jugadoress.Add(josefina);
            azul.Jugadoress.Add(eli);
            azul.Jugadoress.Add(maria);
            azul.Jugadoress.Add(karla);
            azul.Jugadoress.Add(blanca);
            azul.Jugadoress.Add(dani);
            azul.Jugadoress.Add(ale);

            negro.Jugadoress.Add(juan);
            negro.Jugadoress.Add(jose);
            negro.Jugadoress.Add(jesus);
            negro.Jugadoress.Add(luis);
            negro.Jugadoress.Add(carlos);
            negro.Jugadoress.Add(andres);
            negro.Jugadoress.Add(rene);
            negro.Jugadoress.Add(fer);
            negro.Jugadoress.Add(pablo);

            foreach(Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre);
                Console.WriteLine("Lista de los jugadores: ");
                foreach(Jugador jugador in equipo.Jugadoress)
                {
                    Console.WriteLine("*" + jugador.Nombre);
                }
            }

            Console.Read();
        }
    }
}
