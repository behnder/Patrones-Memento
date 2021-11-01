using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Memento
{
    class Originator
    {

        public Juego Estado { get; set; }

        public Memento Guardar()
        {
            return new Memento(Estado);
        }

        public void restaurar(Memento m)
        {
            Estado = m.Estado;
        }

    }
}
