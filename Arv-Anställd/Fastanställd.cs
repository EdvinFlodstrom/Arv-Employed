using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Fastanställd : Anställd
    {
        private double månadslön;
        public Fastanställd(string _namn, double _lön) : base(_namn)
        {
            this.månadslön = _lön;
            BeräknaLön();
        }
        public override double BeräknaLön()
        {            
            return månadslön;
        }
        public override string ToString()
        {
            return base.ToString() + "Lön: " + BeräknaLön();
        }
    }
}