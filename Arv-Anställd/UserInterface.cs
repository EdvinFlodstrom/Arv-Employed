using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Anställd
{
    internal class UserInterface
    {                
        private PersonalHanterare personalHanterare = new PersonalHanterare();
        public UserInterface() { }
        private string AngeTypAvAnställd()
        {
            string svar;
            Console.WriteLine("Ange vilken typ av anställd från följande:  ");
            Console.WriteLine("1. Fastanställd.");
            Console.WriteLine("2. Timanställd.");
            Console.WriteLine("3. Provisionsanställd.");
            Console.WriteLine("4. Bas och provisionsanställd.");

            do
            {
                Console.Write(Environment.NewLine + "Ange svar, 1-4: ");
                svar = Console.ReadLine();
            } while (!SvarCheck(svar, 4));
            return svar;
        }
        private BasOchProvisionsanställd BasOchProvisionsanställd(string namn, int id = 0)
        {
            List<int> provisionOchFörsäljning = ProvisionsEllerBasOchProvisionsanställd(namn);
            int fastLön;
            do
            {
                Console.Write(Environment.NewLine + "Ange vilken fast lön " + namn + " har: ");
                fastLön = ConvertToInt(Console.ReadLine());
            } while (fastLön == 0);

            return new BasOchProvisionsanställd(namn, provisionOchFörsäljning[0],
                provisionOchFörsäljning[1], fastLön, id);
        }
        private int ConvertToInt(string svar)
        {
            int intSvar = 0;
            try
            {
                intSvar = (Convert.ToInt32(svar));
                return intSvar > 0 ? intSvar : 0;
            }
            catch
            {
                Console.WriteLine("Ange en siffra.");
                return 0;
            }
        }
        private Fastanställd Fastanställd(string namn, int id = 0)
        {
            int lön;
            do
            {
                Console.Write(Environment.NewLine + "Ange vilken lön " + namn + " har: ");
                lön = ConvertToInt(Console.ReadLine());
            } while (lön == 0);
            return new Fastanställd(namn, lön, id);
        }
        private Provisionsanställd Provisionsanställd(string namn, int id = 0)
        {
            List<int> provisionOchFörsäljning = ProvisionsEllerBasOchProvisionsanställd(namn);

            return new Provisionsanställd(namn, provisionOchFörsäljning[0], provisionOchFörsäljning[1], id);
        }
        private List<int> ProvisionsEllerBasOchProvisionsanställd(string namn)
        {
            int provision;
            int försäljning;
            do
            {
                Console.Write(Environment.NewLine + "Ange vilken provision " + namn + " har: ");
                provision = ConvertToInt(Console.ReadLine());
                Console.Write(Environment.NewLine + "Ange hur stor försäljning " + namn + " har uppnått: ");
                försäljning = ConvertToInt(Console.ReadLine());
            } while (provision == 0 || försäljning == 0);

            List<int> provisionsanställd = new List<int>
            {
                provision,
                försäljning
            };

            return provisionsanställd;
        }
        public void Run()
        {
            Console.WriteLine("Du har följande alternativ: " + Environment.NewLine + Environment.NewLine + 
                "1. Lägg till en ny anställd." + Environment.NewLine + "2. Skriv ut uppgifter om alla anställda." + 
                Environment.NewLine + "3. Skriv ut namn på alla anställda." + Environment.NewLine + 
                "4. Ändra uppgifter om en anställd." + Environment.NewLine + "5. Avsluta." + Environment.NewLine + Environment.NewLine);
            
            string svar;
            do
            {
                Console.Write("Ange svar, 1-5: ");
                svar = Console.ReadLine();                
            } while (!SvarCheck(svar, 5));
            
            Console.WriteLine();

            if (svar == "1")
            {
                svar = AngeTypAvAnställd();

                Console.Write(Environment.NewLine + "Ange den anställdes namn: ");
                string namn = Console.ReadLine();

                if (svar == "1")
                {                                        
                    personalHanterare.LäggTillAnställd(Fastanställd(namn));
                }
                else if (svar == "2")
                {
                    
                    personalHanterare.LäggTillAnställd(Timanställd(namn));
                }
                else
                {                    
                    if (svar == "3")
                    {
                        personalHanterare.LäggTillAnställd(Provisionsanställd(namn));
                    }
                    else
                    {                        
                        personalHanterare.LäggTillAnställd(BasOchProvisionsanställd(namn));
                    }
                }
            }
            else if (svar == "2")
            {
                foreach (Anställd item in personalHanterare.Anställda)
                {
                    Console.WriteLine("Id: " + item.Id + ", " + item + Environment.NewLine);
                }
            }
            else if (svar == "3")
            {
                Console.WriteLine("Namnen på de anställda är som följer:");
                foreach (string item in personalHanterare.AnställdasNamn)
                {
                     Console.WriteLine(item);
                }
            }
            else if (svar == "4")
            {
                Console.WriteLine("De anställda är som följer: ");
                int personalIndex = 0;
                foreach (Anställd item in personalHanterare.Anställda)
                {
                    Console.Write(++personalIndex);
                    Console.WriteLine(", " + item + Environment.NewLine);
                }
                do
                {
                    Console.Write("Ange siffran på den anställda vars uppgifter du vill ändra på: ");
                    svar = Console.ReadLine();
                } while (!SvarCheck(svar, personalIndex));

                Anställd arbetare = personalHanterare.Anställda[Convert.ToInt32(svar) - 1];

                Console.WriteLine(Environment.NewLine + "Den anställdas uppgifter är som följer: " + Environment.NewLine + 
                    arbetare);

                do
                {
                    Console.Write(Environment.NewLine + "Vad vill du göra med den anställda?" + Environment.NewLine +
                        "1. Ändra uppgifter" + Environment.NewLine + "2. Ta bort anställd." + Environment.NewLine +
                        Environment.NewLine + "Ange val: ");
                    svar = Console.ReadLine();
                } while (!SvarCheck(svar, 2));

                if (svar == "1")
                {
                    svar = AngeTypAvAnställd();

                    if (svar == "1")
                    {
                        personalHanterare.ÄndraAnställd(arbetare, false, Fastanställd(arbetare.Name, arbetare.Id));
                    }
                    else if (svar == "2")
                    {
                        personalHanterare.ÄndraAnställd(arbetare, false, Timanställd(arbetare.Name, arbetare.Id));
                    }
                    else
                    {
                        if (svar == "3")
                        {
                            personalHanterare.ÄndraAnställd(arbetare, false, Provisionsanställd(arbetare.Name, arbetare.Id));
                        }
                        else
                        {
                            personalHanterare.ÄndraAnställd(arbetare, false, BasOchProvisionsanställd(arbetare.Name, arbetare.Id));
                        }
                    }                    
                }
                else
                {
                    personalHanterare.ÄndraAnställd(arbetare, true);
                }
            }
            else if (svar == "5")
            {
                Console.WriteLine("Avslutar.");
                return;
            }

            Console.WriteLine();
            Run();
        }
        private bool SvarCheck(string svar, int accepteradeSvar)
        {
            int intSvar = 0;
            try
            {
                intSvar = (Convert.ToInt32(svar));
            }
            catch
            {
                Console.WriteLine("Ange en siffra." + Environment.NewLine);
                return false;
            }

            for (int i = 1; i <= accepteradeSvar; i++)
            {
                if (intSvar == i)
                {
                    return true;
                }
            }
            Console.WriteLine("Ange en siffra inom givet område." + Environment.NewLine);
            return false;
        }                
        private Timanställd Timanställd(string namn, int id = 0)
        {
            int timLön;
            int antalArbetadeTimmar;
            do
            {
                Console.Write(Environment.NewLine + "Ange vilken timlön " + namn + " har: ");
                timLön = ConvertToInt(Console.ReadLine());
                Console.Write(Environment.NewLine + "Ange hur många timmar " + namn + " har arbetat: ");
                antalArbetadeTimmar = ConvertToInt(Console.ReadLine());
            } while (timLön == 0 || antalArbetadeTimmar == 0);

            return new Timanställd(namn, timLön, antalArbetadeTimmar, id);
        }
    }
}