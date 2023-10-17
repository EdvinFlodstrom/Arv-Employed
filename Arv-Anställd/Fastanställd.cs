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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_namn"></param>
        /// <param name="_lön"></param>
        /// <param name="id">Ange ett värde för id endast när en arbetares uppgifter ändras på. 
        /// Är id = 0 så får arbetarens id ett default-värde.</param>
        public Fastanställd(string _namn, double _lön, int id = 0) : base(_namn, id == 0 ? 0 : id)
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