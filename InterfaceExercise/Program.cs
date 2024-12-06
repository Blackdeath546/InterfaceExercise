using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var bertha   = new Car()
            {
                HasTrunk = true,
                NumberOfSeats = 7,
                Name = "Bertha",
                Make = "Honda",
                Model = "Pilot",
                Color = "Black",
                Logo = "Honda Logo",
                Headquarters = "Honda Headquarters"
            };
            
            var bigBetty = new Truck
            {
                hasTruckBed = true,
                truckBedSpace = "Very Large Truck Bed ;)",
                Name = "Big Betty",
                Make = "Bugatti",
                Model = "ChiRon Sport",
                Color = "Purple",
                Logo = "Bugatti Logo",
                Headquarters = "France",

            };

            var bigDumpy = new SUV
            {
                Rows = 2,
                CargoSpace = "none",
                Logo = "SUV Logo",
                Headquarters = "Japan",
                Name = "Big Dumpy",
                Make = "Toyota",
                Model = "Sport",
                Color = "Green"
            };
            
            var parkingLot = new List<IVehicle>(){ bertha, bigBetty, bigDumpy };

            foreach (var vehicle in parkingLot)
            {
                Console.WriteLine($"Vehicle Type: {vehicle.GetType().Name}\n Name: {vehicle.Name}\n Color: {vehicle.Color}");
            }
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
