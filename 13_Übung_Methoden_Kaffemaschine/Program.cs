//Aufgabe1:
//Erstelle die Klasse Kaffeemaschine.
//Diese soll über die Felder "wasserstand" und bohnenmenge" verfügen.
//Es soll auch zwei static Felder geben namens "maxWasserstand" und "maxBohnenmenge".
//Die Klasse soll im Sinne der Datensicherheit gekapselt sein.

//Aufgabe2:
//Erstelle eine Methode um einen Kaffee zu machen. Dafür soll eine eine bestimmte Menge Wasser und eine bestimmte
//Menge Bohnen verbraucht werden.
//Gib den Kaffee stellvertrenden über einen Console.WriteLine() aus.
//Hinweis: Du musst selbt ein Objekt der Klasse Kaffeemaschine erstellen und beliebige entsprechende Werte zuweisen,
//um dann die Methode ausführen zu können.

//Aufgabe3: Erstelle Methoden um zu prüfen, ob noch ausreichend Wasser und Bohnen für einen Kaffe vorhanden sind. 
//Diese beiden Methoden sollen dann in der für Aufgabe 2 erstellten Methode sinnvoll aufgerufen werden.

//Aufgabe4: Erstelle Methoden um die Wassermenge, als auch die Bohnenmenge wieder auf Maximalstand zu bringen.

//Aufgabe5a: Schreibe Code der es uns ermöglicht wieder und wieder einen Kaffee aus der Maschine zu bekommen.
//Aufgabe5b: Mache diesen Code zu einer Methode der Klasse.
//Aufgabe5c: Verlagere alle bisherigen Methodenaufrufe aus der Programm.cs in die Methode aus 5b.
//Diese Methode soll es dann ermöglichen,
//nach Nutzereingabe entweder einen Kaffee zu bekommen oder eine der Auffüllmethoden auszuführen.

using _13_Übung_Methoden_Kaffemaschine;

Teemaschine teemaschine1 = new Teemaschine();

while (true)
{
    Console.WriteLine("Bitte wählen:");
    Console.WriteLine();
    Console.WriteLine("[1] Grüntee");
    Console.WriteLine("[2] Schwarztee");
    Console.WriteLine("[3] Früchtetee");
    Console.WriteLine("[4] Heißes Wasser");
    Console.WriteLine();
    Console.WriteLine("[5] Menü");

    
    switch (Console.ReadLine())
    {
        case "1":
            teemaschine1.TeeRauslassen(200, 10, "Grüntee");
                
            break;

        case "2":
            teemaschine1.TeeRauslassen(200, 10, "Schwarztee");

            break;
        case "3":
            teemaschine1.TeeRauslassen(200, 20, "Früchtetee");
            
            break;
        case "4":
            teemaschine1.TeeRauslassen(200, 0, "Heißes Wasser");
            
            break;
        case "5":
            Console.WriteLine("[6] Wasser auffüllen");
            Console.WriteLine("[7] Teeblätter auffüllen");

            switch (Console.ReadLine())
            {
                case "6":
                    Console.WriteLine("Wasser wurde aufgefüllt");
                    teemaschine1.Auffüllen("Wasser");
                    break;
                case "7":
                    Console.WriteLine("Tee wurde aufgefüllt");
                    teemaschine1.Auffüllen("Tee");
                    break;
                    
            }
            break;

    }

    Console.WriteLine("Bitte ENTER drücken.");
    Console.ReadLine();
    Console.Clear();












    
    
    

    Console.WriteLine($"Noch {teemaschine1.Wasserstand} ml Wasser im Tank.");
    Console.WriteLine($"Noch {teemaschine1.Teeblattmenge} g Teeblätter im Behälter.");
}

