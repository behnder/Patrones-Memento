using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Memento
{
    class Memento
    {

        public Juego Estado { get; private set; }

        public Memento(Juego estado)
        {
            Estado = estado;
        }

    }
}
