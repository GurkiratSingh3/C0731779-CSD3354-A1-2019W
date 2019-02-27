using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside a = new Countryside();
            a.Data();
        }
    }
    class Countryside
    {
        public void Data()
        {
            
            Village Alst = new Village("Alst", false);
            Village Schvenig = new Village("Schvenig", false);
            Village Maeland = new Village("Maeland", false);
            Village Helmholtz = new Village("Helmholtz", false);
            Village Wessig = new Village("Wesig", false);
            Village Uster = new Village("Uster", false);
            Village Badden = new Village("Badden", true);

    }
    public class Village
    {
        Village Alst;
        Village Schvenig;
        Village Maeland;
        Village Helmholtz;
        Village Wessig;
        Village Uster;
        Village Badden;

        public Village westVillage;
        public Village eastVillage;
        public int DistanceTravelled;
        public string AstrildeVillage;
        public bool isHere;
            public Village(string VillageName, bool AstrildeLocation)
            {
                AstrildeVillage = VillageName;
                isHere = AstrildeLocation;
                if (isHere == false)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Hugi went to **{0}**, He didn't find Astrilde there.", VillageName);
                    Console.WriteLine("-------------------------------------");
                    Console.ReadLine();

                }
                else if (isHere == true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Atlast, Hugi found Astrilde in village named **{0}**", VillageName);
                    Console.WriteLine("**  **");
                    Console.ReadLine();

                    Console.WriteLine("*-------------------------------------------*");
                    Console.WriteLine("An Announcement was posted *The Viking Village Newspaper* later that week: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The Familes of Astridle Guðmundsdóttir and Hugi Ólafur");
                    Console.WriteLine("are Happy to announce the Marriage of their Children.");
                    Console.WriteLine(" ");
                    Console.WriteLine("The Ceremony will take place on the third Sunnudagur of Góa ");
                    Console.WriteLine("at the Temple of Frigga in Alst.");
                    Console.WriteLine(" ");
                    Console.WriteLine("****All are Welcome.*****");
                }
            }
            
        }
       
    }
}
