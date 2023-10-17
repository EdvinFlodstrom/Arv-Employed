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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="provision"></param>
        /// <param name="_försäljning"></param>
        /// <param name="id">Ange ett värde för id endast när en arbetares uppgifter ändras på. 
        /// Är id = 0 så får arbetarens id ett default-värde.</param>
        public Provisionsanställd(string _name, double provision, double _försäljning, int id = 0) : base(_name, id == 0 ? 0 : id)
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