using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class PersonalHanterare 
    {
        private Anställd anställd;      

        private List<Anställd> anställda = new List<Anställd>();
        private List<string> anställdasNamn = new List<string>();
        public List<Anställd> Anställda
        {
            get
            {
                return anställda;
            }
        }
        public List<string> AnställdasNamn
        {
            get
            {
                return anställdasNamn;
            }
        }
        public PersonalHanterare() { }
        public void LäggTillAnställd(Anställd anställd)
        {            
            this.anställd = anställd;

            anställda.Add(this.anställd);
            anställdasNamn.Add(anställd.Name);
        }
        public void ÄndraAnställd(Anställd nuvarandeAnställd, bool taBortAnställd, Anställd nyAnställd = null)
        {
            int indexAvNuvarandeAnställd = 0;
            if (!taBortAnställd)
            {
                indexAvNuvarandeAnställd = anställda.IndexOf(nuvarandeAnställd);
                anställda.Insert(indexAvNuvarandeAnställd, nyAnställd);
            }
            anställda.Remove(nuvarandeAnställd);
            
            if (taBortAnställd)
            {
                anställdasNamn.Remove(nuvarandeAnställd.Name);
            }
            nuvarandeAnställd = null;
        }
    }
}