using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Memento
{
    class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();
        public void AddMemento(Memento m)
        {
            mementos.Add(m);
        }
        public Memento GetMemento(int index)
        {
            return mementos.IndexOf(mementos,index); 
        }


    }
}
