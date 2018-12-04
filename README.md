# Management Summary

Im �K 318 behandeln wir das Thema Objektorientiertes Programmieren. 
Wir haben ein paar Test-�bungen programmiert, die uns dabei sp�ter f�rs Projekt helfen sollen. 
Zus�tzlich wurde noch Stoff repetiert, den wir schon in der Berufsschule gelernt hatten.
Unser Projekt ist es eine Applikation zu entwickeln, die anhand von �ffentlichen Fahrplandaten Verbindungen raussucht und diese Auch korrekt anzeigt. 
Zus�tzlich noch Features, wie die Fahrpl�ne von Stationen auslesen etc. (�hnlich wie die SBB App).

# Zweck des Dokuments

Dieses Dokument dient zur Projektarbeit. Es sind verschiedene Punkte beschrieben, 
wie z.B. Funktionen des Programms, Use Cases, Testf�lle, Installationsanleitung usw.

# Welche Funktionen wurden umgesetzt

1.	A001: Als �V-User m�chte ich Start- und Endstation mittels Textsuche suchen k�nnen.
2. 	A002: Als �V-User m�chte ich die aktuellen, d.h. mindestens die n�chsten vier bis f�nf Verbindungen 
    (Connections) zwischen den beiden gefundenen und Ausgew�hlten Stationen sehen, damit ich weiss wann ich zur Station muss. 
    Um den f�r mich idealen Anschluss zu erwischen.
3.  A003: Als �V-User m�chte ich sehen welche Verbindungen ab einer bestimmten Station vorhanden sind, 
    damit ich bei mir zuhause eine Art Abfahrtstafel (Stationboard) haben kann.
4.  A004: Als �V-Benutzer m�chte ich, dass schon w�hrend meiner Eingabe erst Such-Resultate erscheinen, 
    damit ich effizienter nach Stationen suchen kann.
5.  A005: Als �V-User m�chte ich nicht nur aktuelle Verbindungen suchen k�nnen, 
    sondern auch solche zu einem beliebigen anderen Zeitpunkt, damit ich zuk�nftige Reisen planen kann.

# Mockup

Einfaches Mockup f�r die Applikation:

![Mockup 1](Images/Mockup-1.png)

# Use Cases / AKtivit�tsdiagramm

Die Usecases f�r mein Programm:

![Use Cases](Images/UseCase.jpg)

Das Aktivit�tsdiagramm:

![Aktivitaetsdiagramm](Images/Aktivitaetsdiagramm.jpg)

# Programmierrichtlinien

Was ist der Zweck von gemeinsamen Programmierrichtlinien:
**Wartbarkeit, Lesbarkeit, �sthetik**

Bei der Erstellung von Software sollten immer folgende Faktoren in Erinnerung gerufen werden:

* Kann ich diesen Source-Code auch in einem Jahr noch verstehen?
* Ist meine Software ordentlich strukturiert/modularisiert oder gibt's haufenweise dubiose
  Querverbindungen zwischen den Modulen?
* Was passiert, wenn jemand anderer meinen Code betrachtet ("Code�Review") oder �nderungen vornehmen muss � wird er sich zurechtfinden?
* Erscheint meine Software aus "einem Guss" (konsequentes Anwenden von Kommentierungen, Einr�ckungen, Variablennamen...)?

**Sprache**
Grunds�tzlich orientieren sich viele Variablennamen an der englischen Sprache und die Kommentare sind in Deutsch verfasst, 
sofern nicht Kundenanforderungen dies verhindern. Wie in der Programmierung �blich, ergibt sich oft ein Mix aus deutsch/englisch, 
was aber im Rahmen der nat�rlichen Empfindung zul�ssig ist. Es gelten allgemein die Regeln der neuen deutschen Rechtschreibung.

**Dokumentation**
L�stig, aber notwendig: Inbetriebnahme Anleitungen, Beschreibung von Funktionsbibilotheken, Bedienungsanleitungen, 
Berechnungs-Dokumentationen (�bersetzungsverh�ltnisse...) usw. Verweise auf diese Dokumente finden sich im jeweiligen Info-File.

#### Programmierrichlinien:

**Verwendung der geschweiften Klammern**

Die Zeichen { und } stehen immer als einzige Zeichen in einer Zeile. Zugeh�rige Klammern paare stehen in derselben Spalte.


**Gut:**		
```if(nX > 0)
{
    for(int i = 0; i< 10 i++)
    {
         adValue[int]++;
         adValueY[i]--;
    }
}
```

**Schlecht:**

```if(nX > 0) {
    for(int i = 0; i< 10 i++) {
         adValue[int]++;
         adValueY[i]--; }
}
```

**Notationen:**

**Pascal:** Der erste Buchstabe jeweils gross. **z.B.** ```MyIdentifier```
**Camel:** Am Anfgang klein, danach jeweil der erst Buchstabe gross. **z.B.** ```myIdentifier```

Je nach Bezeichenrtyp (Methode, Konstante, Vaiable...) werden unterschiedliche Notationen angewendet.

|	Bezeichner	|   Notation	|
|---	|---	|
|   Klasse	|   Pascal	| 
|	Methode	|	Pascal	|
|   Variablen	|   Camel	| 
|   Property	|   Pascal	|
|	Interface	|	Pascal mit Pr�fix I	|

**Kommentare:**

Kommentare und Kommentarzeichen dienen der Verst�ndlichkeit und Strukturierung von Code. KOmmentare sind insbesondere dort anzuwenden,
wo eine spezielle Vorgangsweise dokumentiert werden soll. Sinnlose Kommentierung wie
```nTestVar++ // Testvariable inkrementieren```  
sind zu vermeiden, da sich diese Anweisung selbst schon ausreichen beschreibt.

# Systemtests
**Test 01 - Stationsuche**
User m�chte mittels Textfeld Start- und Endstation suchen.

|   Schirtt	|   Aktivit�t	|   Erwartetes Resultat	|
|---	|---	|---	|
|   1	|   Abfahrtsort Gersag Bahnhof in Textfeld eingeben	|   Gersag Bahnhof wird mittels Autocomplete erkannt und eingegeben.	|
|   2	|   Endstation Luzern Bahnhof in Textfeld eingeben	|   Luzern Bahnhof wird mittel Autocomplete erkannt und eingegeben.	|

**Test 02 - Aktuelle Verbindungen Suchen**

User m�chte die aktuellen Verbindungen zwischen Start- und Endstation finden.

|   Schirtt	|   Aktivit�t	|   Erwartetes Resultat	|
|---	|---	|---	|
|   1	|   Abfahrtsort Luzern Bahnhof in Textfeld eingeben	|   Luzern Bahnhof wird mittels Autocomplete erkannt und eingegeben.	|
|   2	|   Endsation Bahnhof S�d in Textfeld eingeben	|   Bahnhof S�d wird mittel Autocomplete erkannt und eingegeben.	|
|	3	|	Find Connections Button klicken	|	Es werden 4-5 Verbindungen angezeigt zwischen Gersag Bhf und Luzern Bhf.	|

**Test 03 - Verbindung nach bestimmter Zeit suchen**

User m�chte die Verbindungen zwischen Start- und Endstation einer bestimmten Zeit finden.

|   Schirtt	|   Aktivit�t	|   Erwartetes Resultat	|
|---	|---	|---	|
|   1	|   Abfahrtsort Emmenbr�cke Bahnhof in Textfeld eingeben	|   Emmenbr�cke Bahnhof wird mittels Autocomplete erkannt und eingegeben.	|
|   2	|   Enstation Luzern Bahnhof in Textfeld eingeben	|   Luzern Bahnhof wird mittel Autocomplete erkannt und eingegeben.	|
|	3	|	Abfahrtszeit eingeben	|	Abfahrtszeit wurde im Datum Feld eingegeben.	|
|	4	|	Find Connections Button klicken	|	Es werden 4-5 Verbindungen angezeigt zwischen Gersag Bhf und Luzern Bhf.	|

**Test 04 - Stationen anhand Ort suchen**

User m�chte Anhand vom Ort alle verf�gbaren Stationen finden.

|   Schirtt	|   Aktivit�t	|   Erwartetes Resultat	|
|---	|---	|---	|
|   1	|  Ortsnamen (Emmenbr�cke) eingeben	|  Es werden alle Bahnh�fe in der n�he von Emmenrb�cke angezeigt.	|

# Installationsanleitung

