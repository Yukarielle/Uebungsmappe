//Programmiere ein Schere, Stein, Papier Spiel. 
//Der User soll eines der Handzeichen wählen können.
//Der Computer wählt per Zufall ein eigenes Zeichen.
//(Recherchiere hierzu Random für C#)
//Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen,
//verloren oder ein Unentschieden hat.
//Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.


string user, pc, wdh;
int computer;
bool nochmal = false;

do
{
    Console.WriteLine("Bitte wähle [Schere], [Stein] oder [Papier]. OHNE BRUNNEN!");

    user = Console.ReadLine();

    Random auswahlPc = new Random();
    computer = auswahlPc.Next(1, 4);

    switch (computer)
    {
        case 1:
            pc = "Schere";
            Console.WriteLine($"Dein Gegner wählt {pc}!");
            Console.WriteLine($"Es steht {user} gegen {pc}.");

            if (user == "Schere" || user == "schere")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (user == "Stein" || user == "stein")
            {
                Console.WriteLine("Du hast gewonnen! Es ist eben kein Glücksspiel!");
            }
            else if (user == "Papier" || user == "papier")
            {
                Console.WriteLine("Du stirbst!");
            }
            else
            {
                Console.WriteLine("So können wir nicht spielen! Du nervst!");
            }

            break;

        case 2:
            pc = "Stein";
            Console.WriteLine($"Dein Gegner wählt {pc}!");
            Console.WriteLine($"Es steht {user} gegen {pc}.");

            if (user == "Stein" || user == "stein")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (user == "Papier" || user == "papier")
            {
                Console.WriteLine("Du hast gewonnen! Es ist eben kein Glücksspiel!");
            }
            else if (user == "Schere" || user == "schere")
            {
                Console.WriteLine("Du stirbst!");
            }
            else
            {
                Console.WriteLine("So können wir nicht spielen! Du nervst!");
            }

            break;

        case 3:
            pc = "Papier";
            Console.WriteLine($"Dein Gegner wählt {pc}!");
            Console.WriteLine($"Es steht {user} gegen {pc}.");

            if (user == "Papier" || user == "papier")
            {
                Console.WriteLine("Unentschieden!");
            }
            else if (user == "Schere" || user == "schere")
            {
                Console.WriteLine("Du hast gewonnen! Es ist eben kein Glücksspiel!");
            }
            else if (user == "Stein" || user == "stein")
            {
                Console.WriteLine("Du stirbst!");
            }
            else
            {
                Console.WriteLine("So können wir nicht spielen! Du nervst!");
            }
            break;

        default:
            Console.WriteLine("Was hast du da eingebeben? So können wir nicht spielen!");
            break;
    }

    Console.WriteLine("Willst du nochmal spielen? (J)a oder (N)ein?");
    wdh = Console.ReadLine();
    if (wdh == "J" || wdh == "j" || wdh == "Ja" || wdh == "ja")
    {
        nochmal = true;
    }
    else if (wdh == "N" || wdh == "n" || wdh == "Nein" || wdh == "nein")
    {
        nochmal = false;
    }
    else
    {
        Console.WriteLine("Du sollst (J)a oder (N)ein eingeben hab ich gesagt! Das wars!");
        nochmal = false;
    }

    Console.Clear();

} while (nochmal == true);


