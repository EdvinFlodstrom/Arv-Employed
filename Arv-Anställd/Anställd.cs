using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Anställd
    {
        private string name;

        public Anställd(string _name)
        {
            this.name = _name;
        }
        public double BeräknaLön()
        {
            return 0;
        }
        public override string ToString()
        {
            return "";
        }
    }
}