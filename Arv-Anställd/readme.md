Loggbok
============

Mall
---------

* Vad har du gjort? Vilka uppgifter?
* Hur har det g�tt?
* Vad var sv�rt? Ber�tta om om n�gra av dina sv�righeter.
* Hur l�ste du sv�rgiheterna?
* L�nka till k�llor du anv�nt dig av, t.ex. artikel p� Stackoverflow, specifik film p� youtube
* F�rs�k att sammanfatta vad du har l�rt dig.

https://daringfireball.net/projects/markdown/basics

2023-10-13
-------------

### 4630 Arv Anst�lld - Del 1
Efter att ha f�tt hj�lp med att hitta till en l�nk som beskrev metoden String.IndexOf s�kte jag lite mer information.
Jag beh�vde anpassa return-v�rdet i en klass som �rvde fr�n en �rvande klass. Med lite testande kom jag fram till f�ljande rad kod:
    `return base.ToString().Insert(base.ToString().IndexOf("L�n: "), Convert.ToString("Fast l�n: " + fastL�n + Environment.NewLine));`
Att det fungerade innebar att jag blev klar med del 1 i uppgift 4630. Jag anv�nde mig av f�ljande l�nkar: 
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.insert?view=net-7.0

Sammantaffningsvis l�rde jag mig om hur man kan modifiera en string p� ett kortfattat s�tt, och mer om arv. Del 1 av uppgift 4630
gick bra allt som allt, men jag st�tte p� en del problem med att skicka med argument till konstrktorn f�r klassen Anst�lld, som �r �verst.
Efter mycket fels�kning kom jag fram till att jag beh�vde anv�nda : base(). Genom det l�rde jag mig mer om arv.


2023-10-13
-------------

### 4630 Arv Anst�lld - Del 2
Den h�r delen av uppgiften tog mig n�gon minut att l�sa, d� jag endast beh�vde l�gga till ordet 
"abstract" f�re "class" i klassen Anst�lld, och �ndra metoden "Ber�knaL�n()" till abstrakt genom att
ta bort dess body och ers�tta ordet "virtual" med "abstract". Jag beh�vde inte �ndra n�got p� n�got annat st�lle i koden, s�
programmet fungerade som innan, efter �ndringarna. 


2023-10-14
-------------
### 4630 Arv Anst�lld - Del 3
Jag har lite problem med tv� delar, n�mligen hur jag b�r skapa varje anst�lld genom klassen UserInterface.
Enligt instruktionerna ska en klass PersonalHanterare ha en metod L�ggTillAnst�lld som l�gger till en anst�lld,
men jag har inte hittat n�got bra s�tt att skapa en instans av PersonalHanterare f�r en anst�lld utan att skapa 
den anst�llda direkt. Om jag g�r f�ljande: 
    `PersonalHanterare personal1 = new PersonalHanterare(new Timanst�lld("�ke", 300, 40));`
...s� skapar jag en timanst�lld �ke direkt i konstruktorn f�r PersonalHanterare, inte med anv�ndning av metoden L�ggTillAnst�lld.
Jag s�kte runt en del efter l�sningar, men hittade inga direkta svar. Jag anv�nde f�ljande l�nkar:
* https://stackoverflow.com/questions/7598088/purpose-of-activator-createinstance-with-example
* https://stackoverflow.com/questions/731452/create-instance-of-generic-type-whose-constructor-requires-a-parameter
* https://stackoverflow.com/questions/7598088/purpose-of-activator-createinstance-with-example
* https://learn.microsoft.com/en-us/dotnet/api/system.activator?view=netframework-4.8#remarks

Jag misst�nker att det �r t�nkt att jag ska g�ra p� annat s�tt, s� jag ska testa lite andra saker.


2023-10-14
---------------
### 4630 Arv Anst�lld - Del 3
Lite senare p� dagen har jag nu kollat runt lite mer, och �ndrat lite saker i koden. I UserInterface skapar jag tidigt en instans av klassen
PersonalHanterare, vars metod L�ggTillAnst�lld jag sedan anv�nder f�r att skapa instanser av klasserna f�r de olika formerna av anst�llning.
Visserligen skapar jag varje instans av klassen i fr�ga i argumentet f�r L�ggTillAnst�lld, men det �r n�ra nog, tror jag. S� det ser nu ut som f�ljande: 
    `personalHanterare.L�ggTillAnst�lld(new Timanst�lld("�ke", 400, 20));`
Det �r inget jag kommer l�mna kvar i koden, d� man sj�lv ska skriva in anst�llning, namn och s� vidare, s� det �r enbart i f�rklarande syfte. Jag 
funderade ocks� p� bra s�tt att se till att man i anv�ndargr�nssnittet svarar en giltig siffra, och kom fram till en l�sning som anv�dner sig av 
en do {} while()-slinga, d�r while()-delen av slingan kollar ifall siffran man angett �r rimlig eller inte. F�r tillf�llet s� anger man ett svar, 
en string, som i metoden SvarCheck(string svar, int accepteradeSvar) testar att konvertera svar till en integer genom en try {}. Ifall det inte g�r
att konvertera har man inte angett en siffra, och d� skrivs ett meddelande ut i en catch {}. Sedan f�r man skriva in en ny siffra. Jag anv�nder
en for-slinga f�r att kolla ifall siffran man angett finns mellan 1 och accepteradeSvar, vilket �r den h�gsta siffran man f�r v�lja. 
Dessutom skapade jag ocks� en egenskap f�r listan �ver anst�llda i klassen PersonalHanterare, som borde vara read-only. Jag anv�nde f�ljande l�nkar:
* https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties?redirectedfrom=MSDN
* https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements

Sammanfattningsvis l�rde jag mig mer om egenskaper och "exception-handling statements".


2023-10-17
--------------
### 4630 Arv Anst�lld - Del 3
Efter att ha funderat en stund p� hur jag skulle kunna �ndra p� de anst�lldas uppgifter, b�de genom att ta bort dem och 
enkla �ndringar, testade jag att l�ta PersonalHanterare �rva fr�n UserInterface. Det var inte en bra id�. 
* https://stackoverflow.com/questions/43693858/how-to-fix-system-stackoverflowexception

Hur som helst fick jag det att fungera efter n�gra timmar, och varje anst�lld har nu �ven ett id som �ndras endast n�r den anst�llde tas bort.
N�r man �ndrar uppgifter f�r en anst�lld tas instansen av klassen bort och ers�tts av en annan, men arbetarens id kvarh�lls.
Det fick jag att fungera med hj�lp av frivilliga parametrar.
* https://stackoverflow.com/questions/199761/how-can-you-use-optional-parameters-in-c
* https://stackoverflow.com/questions/19476730/how-to-delete-object
* https://stackoverflow.com/questions/22106846/c-sharp-delete-instance-of-class
* https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-7.0

I slutet sorterade jag metoderna, objektvariablerna och egenskaperna s� att projektet ser lite b�ttre ut. Allt som allt l�rde jag mig mycket, tror jag.