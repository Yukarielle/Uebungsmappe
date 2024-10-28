//Der User soll angeben können, wieviel Bier in Litern getrunken wurde.
//Daraus wird die Menge des Reinalkohols in Gramm berechnet. 
//Getrunkene Menge in Milliliter * Alkoholgehalt * Dichte des Ethanols.
//Bei Bier also: Getrunkene Menge in Milliliter * 0.05 * 0.8
//Der User soll auch sein Gewicht in Kilogramm angeben. 
//Dann wird der Blutalkoholgehalt in Promille berechnet und auf 2 Nachkommastellen gerundet.
//(Das bitte selbst Recherchieren)
//c = A / (0.65*G)
//c ist der Promillewert, A der aufgenommene Alkohol in Gramm und G das Körpergewicht in kg.
//Es soll dann eine Ausgabe, abhängig vom Promillewert folgen:
//bis 0.3: "Noch akzeptabel. Dennoch vorsichtig sein!"
//bis 0.5: "Achtung! Hände weg vom Steuer."
//bis 0.8: "Das ist jetzt schon ganz schön ordentlich."
//ab 0.8: "Kein Kommentar..."
//Wähle die passenden Datentypen für die jeweils notwendigen Variablen.
//Etwaige Eingabefehler sollen über einen else-Block abgefangen werden.


using System.ComponentModel.Design;

double liter, milliliter, alkoholgehalt, ethanol, reinAlkohol, gewicht, promille, promilleRound;

Console.WriteLine("Du betrittst die Taverne auf der Suche nach dem nächsten Bier an diesem Abend.");
Console.WriteLine("Am Tresen angekommen sieht dich der Gastwirt skeptisch an.");
Console.WriteLine("Bevor du überhaupt deine Bestellung aufgeben kannst, fragt er dich:");
Console.WriteLine("\n\"Wie viel Liter Bier hast du heute schon getrunken?\"");
Console.WriteLine("\nVerwirrt antwortest du ihm:");
liter = Convert.ToDouble(Console.ReadLine());

milliliter = liter * 1000;
alkoholgehalt = 0.05;
ethanol = 0.8;

reinAlkohol = milliliter * alkoholgehalt * ethanol; //Ergebnis ist in gramm!

//Console.WriteLine($"Du hast {reinAlkohol} g Reinalkohol zu dir genommen!");

Console.WriteLine("\nDer Gastwirt mustert dich von oben bis unten..");
Console.WriteLine("\n\"Bevor ich dir noch eins ausschenke, eine letzte Frage...\"");
Console.WriteLine("\nDu schaust ihn fragend an.");
Console.WriteLine("\nWie viel wiegst du?");

Console.WriteLine("\nLangsam wirst du leicht gereizt, antwortest ihm aber:");
Console.Write("kg:");
gewicht = Convert.ToDouble(Console.ReadLine());

promille = reinAlkohol / (0.65 * gewicht);
promilleRound = double.Round(promille, 2);

Console.WriteLine("\nEr murmelt..");
Console.WriteLine($"\"Du hast {promilleRound} Promille im Blut.\"");

if (promilleRound <= 0.3)
{
    Console.WriteLine("\"Noch akzeptabel. Hier hast du noch eins!\"");
    Console.WriteLine("\nDer Gastwirt schiebt dir einen Humpen über die Theke.");
    Console.WriteLine("\n\"Ich will aber keinen Ärger in meinem Gasthaus!\"");
    Console.WriteLine("Das einzige was du dich fragst, ist woher er das wusste...");
}
else if (promilleRound > 0.3 && promilleRound <= 0.5)
{ 
    Console.WriteLine("\"Na sowas! Wag dich heute ja nicht mehr in dein Gefährt! Nur dann kriegste noch eins!\"");
    Console.WriteLine("Das einzige was du dich fragst, ist woher er das wusste...");
}
else if (promilleRound > 0.5 && promilleRound <= 0.8)
{
    Console.WriteLine("\"Das ist jetzt schon ganz schön ordentlich! Mach mir ja keinen Ärger!\"");
    Console.WriteLine("Er schiebt dir, wenn auch zögerlich, einen Humpen Bier über die Theke.");
    Console.WriteLine("Das einzige was du dich fragst, ist woher er das wusste...");
}
else if (promilleRound > 0.8)
{
    Console.WriteLine("Vergiss es! Du bekommst hier heute nichts mehr!");
    Console.WriteLine("Das einzige was du dich fragst, ist woher er das wusste...");
}
else
{
    Console.WriteLine("Error. Eingabe ist ungültig bitte erneut versuchen.");
}


//Lösung Dozent

//double getrunkeneMenge;
//double gewicht;
//double alkGehalt = 0.05d;
//double ethDichte = 0.8d;
//double reinAlk;
//double promille;

//Console.WriteLine("Wie viel Bier in Liter hast du getrunken?");
//getrunkeneMenge = Convert.ToDouble(Console.ReadLine()) * 1000d;

//Console.WriteLine("Nenne mir nun dein Gewicht.");
//gewicht = Convert.ToDouble(Console.ReadLine());

//reinAlk = getrunkeneMenge * alkGehalt * ethDichte;

//promille = Math.Round(reinAlk / (0.65d * gewicht), 2);

//Console.WriteLine($"{promille} Promille");

//if(promille <= 0.3d)
//{
//    Console.WriteLine("Noch akzeptabel");
//}
//else if (promille > 0.3d && promille <= 0.5d)
//{
//    Console.WriteLine("Hände weg vom Steuer!");
//}
//else if (promille > 0.5d && promille <= 0.8d)
//{
//    Console.WriteLine("Ganz schön Ordentlich!");
//}
//else if (promille > 0.8d)
//{
//    Console.WriteLine("Kein Kommentar....!");
//}
//else
//{
//    Console.WriteLine("Da ist was schief gelaufen....");
    
//}



