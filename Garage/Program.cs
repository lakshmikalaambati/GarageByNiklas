
using System;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Car("abc123","Red",4, 5, 6);
            var p = v.GetProps();
            foreach (var item in p)
            {
                System.Console.WriteLine(item.Name + ", " + item.DataType );
            }
            Console.ReadLine();


            // Instansiera ett UserInterface.
            UserInterface ui = new UserInterface();
            // Om användaren skapar eller läser in ett garage, starta användargränssnittet.
            while (ui.Create())
                ui.Start();
        }
    }
}
