using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            UserInterface UI = new UserInterface();

            UI.Run();

            Console.ReadLine();


            /*
            Skapa klass PersonalHanterare. Ska fungera som en databas som håller info, men SKA INTE SKRIVA UT INFO. Endast return.


            Följande ska fungera som nuvarande program. Välj timanställd, provisionsanställd etc. Välj lön, namn (uppgifter).

            Skapa instanser av x i UI när anrop av konstrktorn för PersonalHanterare. INTE innuti PersonalHanterare. 

            Lägg till ny anställd 
            Skriv ut uppgifter om alla anställda
            Skriv ut namn på alla anställda
            Ändra på uppgifter om en anställd (svår) a. Avsluta
                          
             */
        }
    }
}