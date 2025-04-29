using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carOne = new Car();
            carOne.Make = "Huayra";
            carOne.Model = "Pagani";
            carOne.Year = 2025;
            carOne.IsDrivable = true;

            carOne.MakeEngineNoise("Vavroom!");

            carOne.MakeHonkNoise("Ouuugaaa!");

            var carTwo = new Car() {Make = "Ford", Model = "Fusion", IsDrivable = true, Year = 2019 };

            carTwo.MakeEngineNoise("Brrrruumm!");

            carTwo.MakeHonkNoise("Beep");


            var carThree = new Car("Hyundia", "Tucson", false, 2017);

            carThree.MakeHonkNoise("Beepity!");

            carThree.MakeEngineNoise("stutterysputter");


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var carLotOne = new CarLot();

            carLotOne.ParkingLot.Add(carOne);

            carLotOne.ParkingLot.Add(carTwo);

            carLotOne.ParkingLot.Add(carThree);

            carLotOne.CheckCars();

        }
    }
}
