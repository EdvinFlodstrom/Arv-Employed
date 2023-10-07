using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Provisionsanställd : Anställd
    {
        private double provision;
        private double försäljning;

        public Provisionsanställd(string _name, double _provision, 
            double _försäljning)
        {
            this.provision = _provision;
            this.försäljning = _försäljning;
        }
    }
}
