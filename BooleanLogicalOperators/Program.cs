using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunnus
            //kui ka parool on õiged;
            //kui mõlemad, kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis" Tere tulemast!"
            //kui kasutaja tunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus. Proovi uuesti."
            //kt, admin, pr:admin1234


            Console.WriteLine("Palun sisesta kasutajatunnus ja parool");
            string kasutajatunnus = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string kasutajaparool = Console.ReadLine();
            //&& v; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi.
            if(kasutajatunnus == "admin" && kasutajaparool == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Sisselogimine ebaõnnestus.Proovi uuesti");
            }
        }
    }
}
