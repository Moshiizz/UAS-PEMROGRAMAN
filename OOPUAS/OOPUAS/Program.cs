using System;
using System.Collections.Generic;

namespace OOPUAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;

            Console.WriteLine("=== Program Kendaraan Berbasis OOP ===");

            do
            {
                Console.Write("Masukkan jenis kendaraan (car/motorcycle): ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Masukkan merek kendaraan: ");
                string brand = Console.ReadLine();

                if (type == "car")
                    vehicles.Add(new Car(brand));
                else if (type == "motorcycle")
                    vehicles.Add(new Motorcycle(brand));
                else
                    Console.WriteLine("Jenis kendaraan tidak dikenali.");

                Console.Write("Tambah kendaraan lagi? (y/n): ");
                input = Console.ReadLine().ToLower();

                Console.WriteLine();
            } while (input == "y");

            Console.WriteLine("\n=== Daftar Kendaraan ===");
            foreach (var vehicle in vehicles)
            {
                vehicle.StartEngine();
            }

            Console.ReadLine();
        }
    }
}
