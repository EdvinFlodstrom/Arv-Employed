using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Test
    {
        private List<Anställd> anställda = new List<Anställd>();

        public void Run()
        {
            Provisionsanställd provisionsAnställd1 = new Provisionsanställd("Ada", 5, 200000);
            Fastanställd fastAnställd1 = new Fastanställd("Beda", 32000);
            Timanställd timAnställd1 = new Timanställd("Babbage", 200, 40);
            BasOchProvisionsanställd basOchProvisionsAnställd1 = new BasOchProvisionsanställd("Carl", 3, 400000, 10000);
            
            anställda.Add(provisionsAnställd1);
            anställda.Add(fastAnställd1);
            anställda.Add(timAnställd1);
            anställda.Add(basOchProvisionsAnställd1);

            foreach (Anställd item in anställda)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}