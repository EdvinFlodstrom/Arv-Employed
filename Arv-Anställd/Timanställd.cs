using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Timanställd : Anställd
    {
        private double timlön;
        private double arbetadeTimmar;
        public Timanställd(string _name, double _timlön, double _timmar)
        {
            this.timlön = _timlön;
            this.arbetadeTimmar = _timmar;
        }
    }
}
