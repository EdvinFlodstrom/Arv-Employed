using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class BasOchProvisionsanställd : Provisionsanställd
    {
        private double fastLön;
        public BasOchProvisionsanställd(string _namn, double
            _provision, double _försäljning, double _fastLön) : base(_namn, _provision, _försäljning)
        {
            this.fastLön = _fastLön;
        }
        public override double BeräknaLön()
        {
            return (fastLön + (base.BeräknaLön()));
        }
        public override string ToString()
        {
            return base.ToString().Insert(base.ToString().IndexOf("Lön: "), Convert.ToString("Fast lön: " + fastLön + Environment.NewLine));
        }
    }
}