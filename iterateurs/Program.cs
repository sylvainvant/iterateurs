using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterateurs
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Pile<Personne> p = new Pile<Personne>(4);
            p.depile();
            
            p.empile(new Personne("toto", 12));
            p.empile(new Personne("titi", 15));
            p.empile(new Personne("tutu", 25));
            p.depile();
            
           
            p.empile(new Personne("toutou", 28));
            p.empile(new Personne("tintin", 14));
            p.empile(new Personne("tata", 11));
            foreach (Personne pe in p) 
            Console.WriteLine(pe.ToString());
            Console.ReadKey();
     }
    }
}
