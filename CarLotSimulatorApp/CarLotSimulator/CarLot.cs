﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.Write($"\n{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }

        public static int _numberOfCars = 0; 

    }
}
