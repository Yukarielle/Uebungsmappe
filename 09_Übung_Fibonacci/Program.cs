//Der User soll angeben können, wieviele Zahlen der Fibonacci-Folge er berechnet haben möchte. 
//Gib in der Konsole dann die entsprechenden Fibonacci-Zahlen aus.
//Die Fibonacci-Folge beginnt mit den Zahlen 0 und 1.Jede weitere Zahl ergibt sich, in dem man die beiden
//vorherigen Zahlen zusammenzählt.
//Als Beispiel die ersten zehn Zahlen:
//0 1 1 2 3 5 8 13 21 34

//https://www.pohlig.de/Unterricht/Inf2003/

//int fibominus1 = 1;
//int fibominus2 = 0;
//int fibofolge;


//for (int i = 0; i < 20; i++)
//{

//    fibofolge = fibominus1 + fibominus2;
//    fibominus2 = fibominus1;
//    fibominus1 = fibofolge;
//    Console.WriteLine(fibofolge);

//}

//int[] fibofolge = 0;
//int vorangehendeNummer = 0;

//Console.WriteLine("Bitte gib an wie lang die Fibonacci-Folge sein soll [1-100]");


//int fiboLaenge = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < fiboLaenge - 1; i++)
//{
//    for (int sort = 0; sort < fiboLaenge - 1; sort++)
//    {
//        if (fibofolge[sort] > fibofolge[sort + 1])
//        {
//            vorangehendeNummer = fibofolge[sort + 1];
//            fibofolge[sort + 1] = fibofolge[sort];
//            fibofolge[sort] = vorangehendeNummer;
//        }
//    }
//}

//foreach (int reihe in fibofolge)
//{
//    Console.WriteLine(reihe);
//}


using System;



//Console.WriteLine("Bitte gib an wie lang die Fibonacci-Folge sein soll [1-100]");
//int fiboLaenge = Convert.ToInt32(Console.ReadLine());

//int rechnung;
//int fibo1 = 1;
//int fibo2 = 0;


////Console.WriteLine("0");
////Console.WriteLine("1");

//for (int i = 0; i < fiboLaenge - 1; i++)
//{
    
//        rechnung = fibo2 + fibo1;
//        fibo2 = fibo1;
//        fibo1 = rechnung;
//        Console.WriteLine(rechnung);
//}



Console.WriteLine("Bitte gib an wie lang die Fibonacci-Folge sein soll [1-93]");
int fiboLaenge = Convert.ToInt32(Console.ReadLine());

ulong rechnung;
ulong fibo1 = 1;
ulong fibo2 = 0;


Console.WriteLine("0");
Console.WriteLine("1");

for (int i = 2; i < fiboLaenge; i++)
{
    //if (i <= 1)
    //{
    //    rechnung = i;
    //}
    //else
    //{ 
    rechnung = fibo2 + fibo1;
    fibo2 = fibo1;
    fibo1 = rechnung;
    //} 
    
    Console.WriteLine(rechnung);
}

//Lösung Dozent:
//ulong a = 0, b = 1;
//Console.WriteLine("Länge der Fibonacci Folge?");

//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Hier sind {n} Zahlen:");
//Console.WriteLine(a);
//Console.WriteLine(b);

//for (int i = 2; i < n; i++)
//{
//    ulong c = a + b;
//    Console.WriteLine(c);

//    a = b;
//    b = c;
//}