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
            _provision, double _försäjlning, double _lön)
        {
            this.fastLön = _lön;
        }
    }
}
