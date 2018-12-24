using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterateurs
{
    class Pile<T> : IEnumerable
    {
       
        public Pile(int n)
        {
            this.mesT = new T[n];
            this.nbElements = 0;
        }
        public void depile()
        {
            if (this.nbElements > 0) this.nbElements--;
        }
        private bool estPLeine()
        {
            return this.mesT.Length == this.nbElements;
        }
        public void empile(T unT)
        {
            if (!this.estPLeine())
            {
                this.mesT[this.nbElements] = unT; 
                this.nbElements++;
            }
        }
        public T leT(int n) 
        {
            return this.mesT[n];
        }

        private T[] mesT;
        private int nbElements;
        //

         public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.nbElements; i++)
            {
                T n = (T)this.mesT[i];
                yield return n;
            }
        }
        }
       
}
