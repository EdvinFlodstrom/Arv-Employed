using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal abstract class Anställd
    {
        private string name;
        private int id;
        private static int counter = 1;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public Anställd(string name, int id)
        {
            this.name = name;
            if (id == 0)
            {
                this.id = counter;
                ++counter;
            }
            else
            {
                this.id = id;
            }
        }
        public abstract double BeräknaLön();
        public override string ToString()
        {
            return name + Environment.NewLine + this.GetType().Name + Environment.NewLine;
        }
    }
} 