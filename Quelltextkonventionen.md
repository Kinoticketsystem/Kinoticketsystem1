Quelltextkonventionen

�Eine Quelltextzeile wird nur einmal geschrieben, aber hundertmal gelesen.� Dieser Satz veranschaulicht die statistisch nachgewiesene Aussage, dass ca. 80% der Kosten von Software in die Wartung flie�en. Nur sehr selten sind der Autor eines Programms und der Wartungsprogrammierer dieselbe Person. Quelltextkonventionen erleichtern deshalb die Wartung, denn eine einheitliche Gestaltung erlaubt es dem Leser, sich auf die wesentlichen Aspekte eines Quelltextes zu konzentrieren.

Quelltextkonventionen:

    Vor einer Klassendefinition steht immer ein Klassenkommentar, der den Zweck der Klasse beschreibt ("was" nicht "wie")

    Vor jeder Methode einer Klasse steht stets ein Methodenkommentar, der den Dienst beschreibt

    Reihenfolge einer Klasse:
        Zustandsvariablen (alle Variablen mit Public / Private davor)
        Konstruktor(-en)
        Methoden

    Zustandsvariablen sollten immer private deklariert und damit nur innerhalb der Klasse zugreifbar sein
        von au�en durch getter - und setterMethoden drauf zugreifen

    Zustandsvariablen immer _blablabla benennen
	Formen immer Fblablabla benennen

    �Neue� Worte innerhalb eines Bezeichners beginnen mit einem gro�en Buchstaben

    Klassen, Methoden und Variablen sollten �sprechend� benannt werden, etwa mit ganzen Begriffen oder Kurzs�tzen, die die Funktion des Bezeichneten deutlich machen. Methoden sollten stets danach benannt werden, was sie liefern oder was sie machen.

    defensieves Programmieren:
        erst m�glichst einfach und schlicht, dann verbessern
        Reaktionen bei Fehlern klein machen (nicht Programm abst�rzen lassen, wenn etwas unbedeutendes nicht funktionniert)
        viel und oft testen (Test-first)
        Kapselung (Klassen)
