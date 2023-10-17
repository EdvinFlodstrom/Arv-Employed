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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_namn"></param>
        /// <param name="_timlön"></param>
        /// <param name="_timmar"></param>
        /// <param name="id">Ange ett värde för id endast när en arbetares uppgifter ändras på. 
        /// Är id = 0 så får arbetarens id ett default-värde.</param>
        public Timanställd(string _namn, double _timlön, double _timmar, int id = 0) : base(_namn, id == 0 ? 0 : id)
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