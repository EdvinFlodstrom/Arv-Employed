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
        public Timanställd(string _namn, double _timlön, double _timmar) : base(_namn)
        {
            this.timlön = _timlön;
            this.arbetadeTimmar = _timmar;
        }
        public override double BeräknaLön()
        {
            return (timlön * arbetadeTimmar);
        }
        public override string ToString()
        {
            return base.ToString() + "Timlön: " + timlön + Environment.NewLine + "Arbetade timmar: " 
                + arbetadeTimmar + Environment.NewLine + "Lön: " + BeräknaLön();
        }
    }
}