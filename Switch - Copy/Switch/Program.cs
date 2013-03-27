using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch
{
    class Program
    {
        static void Main()
        {


            string carModel;
            string carManufacturer="sj";

            System.Console.Write("Please Enter Your Vehicle Model: ");

            carModel = System.Console.ReadLine();

            switch (carModel)
            {
                case "cerato":
                case "rio":
                case "soul":
                    carManufacturer = "Kia";
                    break;
                case "focus":
                    carManufacturer = "Ford";
                    break;
                case "corolla":
                    carManufacturer = "Toyota";
                    break;
                default:

                    break;
            }

            System.Console.Write("Manufacturer is " + carManufacturer + "\n");

            //  carManufacturer = "0";
            Main();
        }







    }
}

