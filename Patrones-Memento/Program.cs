using System;

namespace Patrones_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombreJuego = "Crash Bandicoot";

            Juego juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 1;

            CareTaker careTaker = new CareTaker();
            Originator originator = new Originator();

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 2;
            originator.Estado = juego;

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 3;
            originator.Estado = juego;

            careTaker.AddMemento(originator.Guardar());

            originator.restaurar(careTaker.GetMemento(0));
            Console.WriteLine(juego);

            juego = new Juego();
            juego.Nombre = nombreJuego;
            juego.Checkpoint = 4;
            originator.Estado = juego;

            careTaker.AddMemento(originator.Guardar());

            originator.restaurar(careTaker.GetMemento(0));
            Console.WriteLine(juego);



        }
    }
}
