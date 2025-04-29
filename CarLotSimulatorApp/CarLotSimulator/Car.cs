using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }

        public string Make   { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;

            Console.WriteLine($"{engineNoise}");

        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;

            Console.WriteLine($"{honkNoise}");
        }

        public Car()
        {

        }

        public Car(string make, string model, bool isDrivable, int year)
        {
            Model = model;
            Make = make;
            IsDrivable = isDrivable;
            Year = year;


        }
    }
}
