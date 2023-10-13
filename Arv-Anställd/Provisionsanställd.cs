using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Provisionsanställd : Anställd
    {
        private double provision;
        private double försäljning;

        public Provisionsanställd(string _name, double provision, 
            double _försäljning) : base(_name)
        {
            this.provision = provision;
            this.försäljning = _försäljning;
        }
        public override double BeräknaLön()
        {
            return ((provision/100) * försäljning);
        }
        public override string ToString()
        {            
            return base.ToString() + "Provision: " + provision + "%" + Environment.NewLine +
                "Försäljning: " + försäljning + Environment.NewLine + "Lön: " + BeräknaLön();
        }
    }
}