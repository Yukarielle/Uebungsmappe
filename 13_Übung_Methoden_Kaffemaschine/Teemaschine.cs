using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Übung_Methoden_Kaffemaschine
{
    internal class Teemaschine
    {
        private int wasserstand;
        private int teeblattmenge;

        private static int maxWasserstand = 600; 
        private static int maxTeeblattmenge = 30;


        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
        public int Teeblattmenge { get => teeblattmenge; set => teeblattmenge = value; }
        public static int MaxWasserstand { get => maxWasserstand; } //set überflüssig weil nicht überschrieben wird.
        public static int MaxTeeblattmenge { get => maxTeeblattmenge; } //set überflüssig weil nicht überschrieben wird.

        //KONSTRUKTOR://
        public Teemaschine() //<-Erstellt Bauplan für Teemaschine mit Wasserstand und Teemenge...
        {
            this.Wasserstand = MaxWasserstand;
            this.Teeblattmenge = MaxTeeblattmenge;

        }

        //METHODEN://

        public bool TeeRauslassen(int wasserverbrauch, int teeverbrauch, string teesorte)
        {
           
            if (InhaltÜberpfrüfen(wasserverbrauch, teeverbrauch) == true)
            {
                Wasserstand = Wasserstand - wasserverbrauch;
                Teeblattmenge = Teeblattmenge - teeverbrauch;
                Console.WriteLine($"{teesorte} wird in Tasse gefüllt.");
                Thread.Sleep(3000);
                Console.WriteLine("Tasse ist voll.");

                return true;
               
            }
            else
            {
                Console.WriteLine("Bitte auffüllen.");
                return false;
            }
        }

        public bool InhaltÜberpfrüfen(int wasserverbrauch, int teeverbrauch)
        {
            if (Wasserstand >= wasserverbrauch && Teeblattmenge >= teeverbrauch)
            {
                return true;
            }
            else
            {
                
                if(Wasserstand < wasserverbrauch)
                {
                    Console.WriteLine("Wasser ist leer.");           
                }

                if (Teeblattmenge < teeverbrauch)
                {
                    Console.WriteLine("Tee ist leer.");
                }

                return false;
            }
        }

        public void Auffüllen(string nachfüllen)
        {
            if (nachfüllen == "Wasser")
            {
                Wasserstand = MaxWasserstand;
            }
            if (nachfüllen == "Tee")
            {
                Teeblattmenge = MaxTeeblattmenge;
            }
        }

        
        
    }
}
