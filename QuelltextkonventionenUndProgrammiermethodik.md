Quelltextkonventionen und Programmiermethodik

„Eine Quelltextzeile wird nur einmal geschrieben, aber hundertmal gelesen.“ Dieser Satz veranschaulicht die statistisch nachgewiesene Aussage, dass ca. 80% der Kosten von Software in die Wartung fließen. Nur sehr selten sind der Autor eines Programms und der Wartungsprogrammierer dieselbe Person. Quelltextkonventionen erleichtern deshalb die Wartung, denn eine einheitliche Gestaltung erlaubt es dem Leser, sich auf die wesentlichen Aspekte eines Quelltextes zu konzentrieren.

Quelltextkonventionen:

    Vor einer Klassendefinition steht immer ein Klassenkommentar, der den Zweck der Klasse beschreibt ("was" nicht "wie")

    Vor jeder Methode einer Klasse steht stets ein Methodenkommentar, der den Dienst beschreibt

    Reihenfolge einer Klasse:
        Zustandsvariablen (alle Variablen mit Public / Private davor)
        Konstruktor(-en)
        Methoden

    Zustandsvariablen sollten immer private deklariert und damit nur innerhalb der Klasse zugreifbar sein
        von außen durch getter - und setterMethoden drauf zugreifen

    Zustandsvariablen immer _blablabla benennen
	Formen immer Fblablabla benennen

    „Neue“ Worte innerhalb eines Bezeichners beginnen mit einem großen Buchstaben

    Klassen, Methoden und Variablen sollten „sprechend“ benannt werden, etwa mit ganzen Begriffen oder Kurzsätzen, die die Funktion des Bezeichneten deutlich machen. Methoden sollten stets danach benannt werden, was sie liefern oder was sie machen.

    defensieves Programmieren:
        erst möglichst einfach und schlicht, dann verbessern
        Reaktionen bei Fehlern klein machen (nicht Programm abstürzen lassen, wenn etwas unbedeutendes nicht funktionniert)
        viel und oft testen (Test-first)
        Kapselung (Klassen)

Am besten wird fast alles was wir wirklich programmieren in den Klassen programmiert und in den Formen (=GUIs) wird dann nur die 
Methode der dazugehörenden Klasse aufgerufen. Zum Beispiel in der Form Tagesplan, soll es den Button "FilmÄndern" geben. Dann 
wird in dem Klickereignis nur die Methode der Klasse Tagesplan aufgerufen (Tagesplan.FilmÄndern). Dadurch stehen in der Form nur 
graphische Sachen und in der Klasse die richtigen technischen und fachlichen Implemantationen. (Alles wird etwas übersichtlicher 
und das entspricht dem Prinzip der Kapselung)
