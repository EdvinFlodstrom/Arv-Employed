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
    return base.ToString().Insert(base.ToString().IndexOf("L�n: "), Convert.ToString("Fast l�n: " + fastL�n + Environment.NewLine));
Att det fungerade innebar att jag blev klar med del 1 i uppgift 4630. Jag anv�nde mig av f�ljande l�nkar: 
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.insert?view=net-7.0

Sammantaffningsvis l�rde jag mig om hur man kan modifiera en string p� ett kortfattat s�tt, och mer om arv. Del 1 av uppgift 4630
gick bra allt som allt, men jag st�tte p� en del problem med att skicka med argument till konstrktorn f�r klassen Anst�lld, som �r �verst.
Efter mycket fels�kning kom jag fram till att jag beh�vde anv�nda : base(). Genom det l�rde jag mig mer om arv.