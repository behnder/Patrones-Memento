using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Memento
{
    class Juego
    {
        public string Nombre { get; set; }
        public int Checkpoint { get; set; }

        public override string ToString()
        {
            return $"Juego [nombre= {Nombre}, checkpoint ${Checkpoint}";
        }


    }
}
