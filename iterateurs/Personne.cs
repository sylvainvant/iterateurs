using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterateurs
{
    class Personne
    {
        private string nom;
        private int age;
        public Personne(string nom, int age)
        {
            this.nom = nom;
            this.age=age;
        }

        public override string ToString()
        {
            return this.nom + " " + this.age.ToString() ;
        }      
    }
}
