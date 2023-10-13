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
    return base.ToString().Insert(base.ToString().IndexOf("Lön: "), Convert.ToString("Fast lön: " + fastLön + Environment.NewLine));
Att det fungerade innebar att jag blev klar med del 1 i uppgift 4630. Jag använde mig av följande länkar: 
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-7.0
* https://learn.microsoft.com/en-us/dotnet/api/system.string.insert?view=net-7.0

Sammantaffningsvis lärde jag mig om hur man kan modifiera en string på ett kortfattat sätt, och mer om arv. Del 1 av uppgift 4630
gick bra allt som allt, men jag stötte på en del problem med att skicka med argument till konstrktorn för klassen Anställd, som är överst.
Efter mycket felsökning kom jag fram till att jag behövde använda : base(). Genom det lärde jag mig mer om arv.