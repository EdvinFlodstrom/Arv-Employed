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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_namn"></param>
        /// <param name="_provision"></param>
        /// <param name="_försäljning"></param>
        /// <param name="_fastLön"></param>
        /// <param name="id">Ange ett värde för id endast när en arbetares uppgifter ändras på. 
        /// Är id = 0 så får arbetarens id ett default-värde.</param>
        public BasOchProvisionsanställd(string _namn, double _provision, double _försäljning, double _fastLön, int id = 0) 
            : base(_namn, _provision, _försäljning, id == 0 ? 0 : id)
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