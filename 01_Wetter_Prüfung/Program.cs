//Der User soll dir mitteilen, ob das Wetter gerade "sonning" oder "regnerisch" ist.
//Auch die Temperatur soll der User angeben können.
//Liegt die Temperatur bei oder über 20°C und es ist sonning, empfehle dem User ein T-Shirt zu tragen.
//Liegt die Temperatur unter 20°C und es ist sonnig, empfehle eine Jacke anzuziehen.
//Bei regnerischen Wetter werden ebenfalls die zur Temperatur passenden Kleidungsempfehlungen ausgesprochen
//und der User soll darauf hingewiesen werden, dass er einen Regenschirm mitnehmen soll.
//Etwaige falsche Eingaben sollen über einen else-Block abgefangen werden.



//string wetter;

//Console.WriteLine("User, ist es heute \"sonnig\" oder \"regnerisch\"?");
//Console.Write("Antwort: ");
//wetter = Console.ReadLine();


//Console.WriteLine("User, wie Warm ist es heute?");
//Console.Write("°C: ");
//int temperatur = Convert.ToInt32(Console.ReadLine());



//if (temperatur >= 20)
//{
//    Console.WriteLine("Heute empfehle ich ein T-Shirt zu tragen!");
    
//    if (wetter == "regnerisch")
//    {
//        Console.WriteLine("Da es regnet nimm auch einen Regenschirm mit!");
//    }
//}
//else if (temperatur < 20)
//{
//    Console.WriteLine("Du solltest eine Jacke anziehen!");

//    if (wetter == "regnerisch")
//    {
//        Console.WriteLine("Da es regnet nimm auch einen Regenschirm mit!");
//    }
//}
//else if (temperatur > 50)
//{
//    Console.WriteLine("Jetzt helfen dir auch die luftigsten Klamotten nicht mehr!");
//}
//else
//{
//    Console.WriteLine("Ungültige Eingabe.");
//}



//Mit Bool

string wetter;

Console.WriteLine("User, ist es heute \"sonnig\" oder \"regnerisch\"?");
Console.Write("Antwort: ");
wetter = Console.ReadLine();



Console.WriteLine("User, wie Warm ist es heute?");
Console.Write("°C: ");
int temperatur = Convert.ToInt32(Console.ReadLine());


//bool sonnigWarm = (wetter == "sonnig" && temperatur >= 20);
bool sonnigKalt = (wetter == "sonnig" && temperatur < 20);
bool regenWarm = (wetter == "regnerisch" && temperatur >= 20);
bool regenKalt = (wetter == "regnerisch" && temperatur < 20); //Vergleich immer (string == string && int == int) NICHT (string && int == int)


if (wetter == "sonnig" && temperatur >= 20) //<--statt bool deklarieren
{
    Console.WriteLine("Heute ist es warm und sonnig, du solltest ein T-Shirt tragen!");

}
else if (sonnigKalt)
{
    Console.WriteLine("Heute ist es zwar sonnig aber kalt, du solltet eine Jacke anziehen.");
}
else if (regenWarm)
{
    Console.WriteLine("Heute ist es zwar warm aber es regnet, du solltest einen Regenschirm mitnehmen.");
}
else if (regenKalt)
{
    Console.WriteLine("Heute ist es kalt und regnerisch. Pack dich dick und wetterfest ein und nimm den Regenschirm mit.");
}
else
{
    Console.WriteLine("Das Wetter spielt verrückt! Oder du hast dich einfach nur vertippt...");
}



//Lösung Dozent:

//Console.WriteLine("Hallo User! Ist es gerade regnerisch oder sonnig?");
//string wetterbedingungen = Console.ReadLine().ToLower();
//Console.WriteLine("Und wie viel Grad eträgt gerade die Temperatur?");

//int temperatur2 = Convert.ToInt32(Console.ReadLine());

//if (temperatur2 >= 20 && wetterbedingungen == "sonnig")
//{
//    Console.WriteLine("T-Shirt Zeit!");
//}
//else if (temperatur2 >= 20 && wetterbedingungen == "regnerisch")
//{
//    Console.WriteLine("T-Shirt Zeit mit Schirm!");
//}
//else if (temperatur2 < 20 && wetterbedingungen == "sonnig")
//{
//    Console.WriteLine("Schön aber mit Jacke!");
//}
//else if (temperatur2 < 20 && wetterbedingungen == "regnerisch")
//{
//    Console.WriteLine("Dreckswetter! Jacke und Schirm");
//}
//else
//{
//    Console.WriteLine("Oh je da ist was schief gelaufen...");