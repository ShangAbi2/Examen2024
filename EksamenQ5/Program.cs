using System;
using System.Collections.Generic;
using System.Linq;

namespace EksamenQ5;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "cars.csv"; // Angi stien til CSV-filen
        List<Car> cars = CarService.GetCarsFromCsv(filePath);

        // 1) Skriv ut alle biler fra og med årsmodell 2020 og nyere.
        var recentCars = cars.Where(car => car.Year >= 2020).ToList();
        Console.WriteLine("Biler fra 2020 og nyere:");
        foreach (var car in recentCars)
        {
            Console.WriteLine(car);
        }

        // 2) Skriv ut alle biler som har en kilometerstand mindre enn 30000.
        var lowMileageCars = cars.Where(car => car.Milage < 30000).ToList();
        Console.WriteLine("\nBiler med kilometerstand under 30000:");
        foreach (var car in lowMileageCars)
        {
            Console.WriteLine(car);
        }

        // 3) Skriv ut alle biler har gått mindre enn 30000 km og koster mindre enn 100000 kroner.
        var affordableLowMileageCars = cars.Where(car => car.Milage < 30000 && car.Price < 100000).ToList();
        Console.WriteLine("\nBiler under 30000 km og under 100000 kroner:");
        foreach (var car in affordableLowMileageCars)
        {
            Console.WriteLine(car);
        }
    }
}