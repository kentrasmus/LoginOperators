using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Palun sisesta kasutajatunnus");
            string kasutajatunnus = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string kasutajaparool = Console.ReadLine();
            //&& v; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi.
            if (kasutajatunnus == "admin" && kasutajaparool == "admin1234")
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
