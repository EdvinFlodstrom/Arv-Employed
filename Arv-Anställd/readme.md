Loggbok
============

Mall
---------

* Vad har du gjort? Vilka uppgifter?
* Hur har det gått?
* Vad var svårt? Berätta om om några av dina svårigheter.
* Hur löste du svårgiheterna?
* Länka till källor du använt dig av, t.ex. artikel på Stackoverflow, specifik film på youtube
* Försök att sammanfatta vad du har lärt dig.

https://daringfireball.net/projects/markdown/basics

2023-10-13
-------------

### 4630 Arv Anställd - Del 1
Efter att ha fått hjälp med att hitta till en länk som beskrev metoden String.IndexOf sökte jag lite mer information.
Jag behövde anpassa return-värdet i en klass som ärvde från en ärvande klass. Med lite testande kom jag fram till följande rad kod:
    `return base.ToString().Insert(base.ToString().IndexOf("Lön: "), Convert.ToString("Fast lön: " + fastLön + Environment.NewLine));`
Att det fungerade innebar att jag blev klar med del 1 i uppgift 4630. Jag använde mig av följande länkar: 
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.insert?view=net-7.0

Sammantaffningsvis lärde jag mig om hur man kan modifiera en string på ett kortfattat sätt, och mer om arv. Del 1 av uppgift 4630
gick bra allt som allt, men jag stötte på en del problem med att skicka med argument till konstrktorn för klassen Anställd, som är överst.
Efter mycket felsökning kom jag fram till att jag behövde använda : base(). Genom det lärde jag mig mer om arv.


2023-10-13
-------------

### 4630 Arv Anställd - Del 2
Den här delen av uppgiften tog mig någon minut att lösa, då jag endast behövde lägga till ordet 
"abstract" före "class" i klassen Anställd, och ändra metoden "BeräknaLön()" till abstrakt genom att
ta bort dess body och ersätta ordet "virtual" med "abstract". Jag behövde inte ändra något på något annat ställe i koden, så
programmet fungerade som innan, efter ändringarna. 


2023-10-14
-------------
### 4630 Arv Anställd - Del 3
Jag har lite problem med två delar, nämligen hur jag bör skapa varje anställd genom klassen UserInterface.
Enligt instruktionerna ska en klass PersonalHanterare ha en metod LäggTillAnställd som lägger till en anställd,
men jag har inte hittat något bra sätt att skapa en instans av PersonalHanterare för en anställd utan att skapa 
den anställda direkt. Om jag gör följande: 
    `PersonalHanterare personal1 = new PersonalHanterare(new Timanställd("Åke", 300, 40));`
...så skapar jag en timanställd Åke direkt i konstruktorn för PersonalHanterare, inte med användning av metoden LäggTillAnställd.
Jag sökte runt en del efter lösningar, men hittade inga direkta svar. Jag använde följande länkar:
* https://stackoverflow.com/questions/7598088/purpose-of-activator-createinstance-with-example
* https://stackoverflow.com/questions/731452/create-instance-of-generic-type-whose-constructor-requires-a-parameter
* https://stackoverflow.com/questions/7598088/purpose-of-activator-createinstance-with-example
* https://learn.microsoft.com/en-us/dotnet/api/system.activator?view=netframework-4.8#remarks

Jag misstänker att det är tänkt att jag ska göra på annat sätt, så jag ska testa lite andra saker.


2023-10-14
---------------
### 4630 Arv Anställd - Del 3
Lite senare på dagen har jag nu kollat runt lite mer, och ändrat lite saker i koden. I UserInterface skapar jag tidigt en instans av klassen
PersonalHanterare, vars metod LäggTillAnställd jag sedan använder för att skapa instanser av klasserna för de olika formerna av anställning.
Visserligen skapar jag varje instans av klassen i fråga i argumentet för LäggTillAnställd, men det är nära nog, tror jag. Så det ser nu ut som följande: 
    `personalHanterare.LäggTillAnställd(new Timanställd("Åke", 400, 20));`
Det är inget jag kommer lämna kvar i koden, då man själv ska skriva in anställning, namn och så vidare, så det är enbart i förklarande syfte. Jag 
funderade också på bra sätt att se till att man i användargränssnittet svarar en giltig siffra, och kom fram till en lösning som anvädner sig av 
en do {} while()-slinga, där while()-delen av slingan kollar ifall siffran man angett är rimlig eller inte. För tillfället så anger man ett svar, 
en string, som i metoden SvarCheck(string svar, int accepteradeSvar) testar att konvertera svar till en integer genom en try {}. Ifall det inte går
att konvertera har man inte angett en siffra, och då skrivs ett meddelande ut i en catch {}. Sedan får man skriva in en ny siffra. Jag använder
en for-slinga för att kolla ifall siffran man angett finns mellan 1 och accepteradeSvar, vilket är den högsta siffran man får välja. 
Dessutom skapade jag också en egenskap för listan över anställda i klassen PersonalHanterare, som borde vara read-only. Jag använde följande länkar:
* https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties?redirectedfrom=MSDN
* https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements

Sammanfattningsvis lärde jag mig mer om egenskaper och "exception-handling statements".


2023-10-17
--------------
### 4630 Arv Anställd - Del 3
Efter att ha funderat en stund på hur jag skulle kunna ändra på de anställdas uppgifter, både genom att ta bort dem och 
enkla ändringar, testade jag att låta PersonalHanterare ärva från UserInterface. Det var inte en bra idé. 
* https://stackoverflow.com/questions/43693858/how-to-fix-system-stackoverflowexception

Hur som helst fick jag det att fungera efter några timmar, och varje anställd har nu även ett id som ändras endast när den anställde tas bort.
När man ändrar uppgifter för en anställd tas instansen av klassen bort och ersätts av en annan, men arbetarens id kvarhålls.
Det fick jag att fungera med hjälp av frivilliga parametrar.
* https://stackoverflow.com/questions/199761/how-can-you-use-optional-parameters-in-c
* https://stackoverflow.com/questions/19476730/how-to-delete-object
* https://stackoverflow.com/questions/22106846/c-sharp-delete-instance-of-class
* https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-7.0

I slutet sorterade jag metoderna, objektvariablerna och egenskaperna så att projektet ser lite bättre ut. Allt som allt lärde jag mig mycket, tror jag.