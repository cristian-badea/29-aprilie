using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI
{
    public class Program
    {
        static void Main()
        {
            string adresa = "http://localhost:8088";

            using (WebApp.Start<Startup>(adresa))
            {
                Console.WriteLine("Apasa o tasta pt inchiderea serviciului");
                Console.ReadLine();
            }
        }

    }
}