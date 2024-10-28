////Aufgabe1: Lottozahlen
////Erstelle ein int[] lottozahlen mit der Länge 49.
////Schreibe dann einen Code, der dieses Array automatisch mit den Zahlen 1 - 49 befüllt.

////Lösung Dozent:
//int[] lottozahlen = new int[49];
//for (int i = 0; i < 49; i++)
//{
//    lottozahlen[i] = i + 1;
//}

////Aufgabe2: Ziehung der Lottozahlen
////Aus dem Array unserer Lottozahlen sollen nun sechs Zahlen zufällig gezogen werden.
////Diese sechs Zahlen müssen in einem neuen Array abgelegt werden.
////Verwende Random für die zufällige Ziehung.
////Bei gezogenen Zahlen darf es zu keiner Dopplung kommen.

////Lösung Dozent:
//Random rnd = new Random(); //<-Zur erzeugung einer Zufallszahl
//int[] gezogeneZahlen = new int[6];

//for (int i = 0; i < 6; i++)
//{
//    //Variablen die für die weitere Logik notwendig sind:
//    int zufallsindex;
//    int gezZahl;
//    int bereitsGezogen = -1;

//    do
//    {
//        zufallsindex = rnd.Next(0, lottozahlen.Length);
//        //Die Variable rndm erzeugt mit der Next()-Methode eine zufällige Zahl zwischen 0 und 48 die
//        //sie als Wert speichert. Dieser Wert wird zufallsIndex als Wert zugewiesen.

//        gezZahl = lottozahlen[zufallsindex];
//        //Der Wert von zufallsIndex ist der Index den wir uns im array lottozahlen[] ansehen und der
//        //Variable gezZahl zuweisen.

//    }
//    while (gezZahl == bereitsGezogen);
//    //Die Kondition der do-while-Schleife prüft nun ob der Wert von gezZahl gleich dem Wert von
//    //bereitsGezogen, also -1 ist. Ist das der Fall, wird die do-while-Schleife ein weiteres mal ausgeführt.
//    //Nur wenn der Wert ein anderer ist als -1 in gezZahl, kann die Schleife verlassen werden.

//    lottozahlen[zufallsindex] = bereitsGezogen;
//    //Der Wert, der im Array lottozahlen[] mit der Variable zufallsIndex bestimmt wurde,
//    //bekommt den Wert von bereitsGezogenen zugewiesen. Wir überschreiben den Wert also mit dem Wert -1.
//    gezogeneZahlen[i] = gezZahl;

//}

////1 2 3 4 -1 6 -1 -1 9 10 <--Lottozahlen (werden bei Ziehung durch -1 ersetzt)
////0 1 2 3 4  5 5  7  8  9 <--Position (nimmt er eine Position die schon -1 ist, wiederholt sich die while-Schleife)

////Aufgabe 3: User-Eingabe und Gewinnausgabe
////Der User soll in der Lage sein, sechs Zahlen einzugeben.
////Diese werden in einem Array abgelegt. 
////Danach soll überprüft werden, wieviele Zahlen der User im Vergleich zu den gezogenen Lottozahlen richtig
////getippt hat. Sprich, wieviele Zahlen in den beiden Arrays sind gleich. 
////Gib in der Konsole aus, wieviele Richtige getippt wurden.

//foreach (int i in gezogeneZahlen)
//Console.Write($"{i} ");

//int[] tippZahlen = new int[6];

//Console.WriteLine("\n Bitte gib nun 6 Zahlen zwischen 1 und 49 ein.\nBitte bestätige jede Eingabe mit Enter.");

////////////////Minimallösung: <--- Bitte gleich wieder vergessen!
//////////////tippZahlen[0] = Convert.ToInt32(Console.ReadLine());
//////////////tippZahlen[1] = Convert.ToInt32(Console.ReadLine());
//////////////tippZahlen[2] = Convert.ToInt32(Console.ReadLine());
//////////////tippZahlen[3] = Convert.ToInt32(Console.ReadLine());
//////////////tippZahlen[4] = Convert.ToInt32(Console.ReadLine());
//////////////tippZahlen[5] = Convert.ToInt32(Console.ReadLine());

////////Die Minimallösung kann man mit Hilfe einer for-Schleife "automatisieren":
////for (int i = 0; i < tippZahlen.Length; i++)
////{
////    tippZahlen[i] = Convert.ToInt32(Console.ReadLine());
////}

//for (int i = 0; i < tippZahlen.Length; i++)
//{
//    bool doppelt;
//    do
//    {
//        doppelt = false;
//        tippZahlen[i] = Convert.ToInt32(Console.ReadLine());

//        for (int j = 0; j < i; j++)
//        {
//            if (tippZahlen[j] == tippZahlen[i])
//            {
//                doppelt = true;
//            }
//        }
//    }
//    while (tippZahlen[i] <= 0 || tippZahlen[i] > 49 || doppelt);
//}
////Alles in der for-Schleife überprüft nur die Usereingabe auf mögliche fehl und Doppeleingaben.

//int anzahlRichtige = 0;
//for(int i =0; i < gezogeneZahlen.Length; i++)
//{
//    //////Minimallösung:
//    //////if (tippZahlen[0] == gezogeneZahlen[i]) //<--geschweifte Klammern nur wegelassen um zeit zu sparen xD
//    //////    anzahlRichtige++;
//    //////if (tippZahlen[1] == gezogeneZahlen[i])
//    //////    anzahlRichtige++;
//    //////if (tippZahlen[2] == gezogeneZahlen[i])
//    //////    anzahlRichtige++;
//    //////if (tippZahlen[3] == gezogeneZahlen[i])
//    //////    anzahlRichtige++;
//    //////if (tippZahlen[4] == gezogeneZahlen[i])
//    //////    anzahlRichtige++;
//    //////if (tippZahlen[5] == gezogeneZahlen[i])
//    //////    anzahlRichtige++;
    
//    //Die Minimallösung wird mit Hilfe einer weiteren, inneren for-Schleife "automatisiert".
//    for (int j = 0; j < tippZahlen.Length; j++)
//    {
//        if (tippZahlen[j] == gezogeneZahlen[i])
//        {
//            anzahlRichtige++;
//            break;
//        }
//    }

//    Console.WriteLine($"Du hast {anzahlRichtige} Richtige!");
//}


//////////////////////////////////////////MEINE "LÖSUNG"!!!!!!!//////////////////////////////////////

//Aufgabe 1:

int[] lottozahlen;
lottozahlen = new int[50];

for(int i = 1; i < 50; i++) //<-NICHT FOREACH VERWENDEN, das gibt immer nur konstant die Menge des arrays aus.
{
    lottozahlen[i] = i;
    Console.Write(lottozahlen[i] + " ");
    
}

Console.WriteLine();
Console.WriteLine();

//Aufgabe 2:

Random mix = new Random();
int[] ziehung = new int[6];
int zahl = 0;
bool zahlIndentisch = true;

for (int i = 0; i < 6; i++) 
{
    while (zahlIndentisch == true)
    {
        zahl = mix.Next(1, 50);
        zahlIndentisch = false;    //<--Wenn while wiederholt, wieder auf false setzten sonst werden die vorher gegangenen
                                    // Nummern ignoriert

        for (int j = 0; j < 6; j++)
        {
            if (ziehung[j] == zahl)  //<--wenn Zahl ungleich....
            {
               zahlIndentisch = true; //<--tritt das nicht in Kraft und While wiederholte von oben (ohne die erste for)
                                        //bis Zustand eintritt, dann verlässt er die Schleife...
            }
        }
                            
    }
    
    ziehung[i] = zahl; //<--- und speichert den Wert hier ab.
    Console.Write(ziehung[i] + " ");
    zahlIndentisch = true;
}

Console.WriteLine();

//Aufgabe 3

int[] userAuswahl = new int [6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Bitte wähle die {i+1}te Lottozahl aus");
    userAuswahl[i] = Convert.ToInt32(Console.ReadLine());

}
