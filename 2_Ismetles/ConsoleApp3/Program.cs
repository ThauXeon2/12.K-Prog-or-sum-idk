namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OneNum onenum = new OneNum();
            PlaneManager manager = new PlaneManager();

            // 1.0 feladat
            onenum.Nums();

            //1.1-1.5 feladatok
            onenum.Calc();

            // 2.4. feladat
            Console.WriteLine("Személyszállítók nevei:");
            foreach (var name in manager.GetPlaneNamesByType("Személyszállító"))
                Console.WriteLine(name);

            // 2.5. feladat
            Console.WriteLine("\n2000-ben már létező repülők nevei:");
            foreach (var name in manager.GetPlaneNamesExistingInYear(2000))
                Console.WriteLine(name);

            // 2.6. feladat
            Console.WriteLine("\nRepülők száma típusonként:");
            foreach (var kvp in manager.GetPlaneCountByType())
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            // 2.7. feladat
            Console.WriteLine("\nLegnagyobb sebesség típusonként:");
            foreach (var kvp in manager.GetMaxSpeedByType())
                Console.WriteLine($"{kvp.Key}: {kvp.Value} km/h");

            // 2.8. feladat
            Console.WriteLine("\nLegalább 3 szavas nevű repülők:");
            foreach (var name in manager.GetPlaneNamesWithAtLeastThreeWords())
                Console.WriteLine(name);

            // 2.9. feladat
            Console.WriteLine("\nÁtlagsebesség típusonként:");
            foreach (var kvp in manager.GetAverageSpeedByType())
                Console.WriteLine($"{kvp.Key}: {kvp.Value:F2} km/h");

            // 2.10. feladat
            Console.WriteLine("\nMin. 100 fős kapacitású repülők (kapacitás szerint növekvő):");
            foreach (var name in manager.GetPlaneNamesByMinCapacity(100))
                Console.WriteLine(name);

            // 2.11. feladat
            Console.WriteLine("\n5 leggyorsabb repülő:");
            foreach (var name in manager.GetFastestPlanes(5))
                Console.WriteLine(name);

            // 2.12. feladat
            Console.WriteLine("\n100-400 fő közötti kapacitású repülők (ABC sorrendben):");
            foreach (var name in manager.GetPlaneNamesByCapacityRange(100, 400))
                Console.WriteLine(name);

            // 2.13. feladat
            Console.WriteLine("\n2000 után készült, min. 900 km/h sebességű repülők:");
            foreach (var name in manager.GetPlaneNamesByYearAndMinSpeed(2000, 900))
                Console.WriteLine(name);

            // 2.14. feladat
            Console.WriteLine($"\nLegnagyobb kapacitású repülő (min. 100 fő): {manager.GetLargestCapacityPlaneName(100)}");

            // 2.15. feladat
            string oldestFighter = manager.GetOldestPlaneNameByType("Vadászgép");
            Console.WriteLine($"Legrégebbi vadászgép: {oldestFighter}");

            // 2.16. feladat
            Console.WriteLine($"2000 utáni repülők átlagos kapacitása: {manager.GetAverageCapacityFromYear(2000):F2}");

            // 2.17. feladat
            Console.WriteLine("\n\"boeing\" nevű repülők:");
            foreach (var name in manager.GetPlaneNamesContaining("boeing"))
                Console.WriteLine(name);

            // 2.18. feladat
            Console.WriteLine("\nAirbus vagy Boeing kezdetű nevű repülők (gyártási év szerint csökkenő):");
            foreach (var plane in manager.GetPlanesStartingWith("Airbus", "Boeing"))
                Console.WriteLine($"{plane.PlaneName} ({plane.BuiltYear})");

            // 2.19. feladat
            Console.WriteLine("\n2200 km/h-nál gyorsabb vadászgépek:");
            foreach (var name in manager.GetPlaneNamesByTypeAndMinSpeed("Vadászgép", 2200))
                Console.WriteLine(name);

            // 2.20. feladat
            Console.WriteLine("\nÖsszes férőhely típusonként:");
            foreach (var kvp in manager.GetTotalCapacityByType())
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            // 2.21. feladat
            Console.WriteLine("\nLegnagyobb kapacitású repülő típusonként:");
            foreach (var kvp in manager.GetLargestCapacityPlaneNamePerType())
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            // 2.22. feladat
            Console.WriteLine("\n3 legújabb, min. 150 fős repülő:");
            foreach (var plane in manager.GetThreeNewestPlanesWithMinCapacity())
                Console.WriteLine($"{plane.PlaneName} ({plane.BuiltYear})");

            // 2.23. feladat
            Console.WriteLine("\n2000 után készült repülők száma típusonként:");
            foreach (var kvp in manager.GetPlaneCountByTypeAfterYear(2000))
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");

            // 2.24. feladat
            Console.WriteLine("\n700 km/h-nál nagyobb átlagsebességű típusok:");
            foreach (var typeName in manager.GetTypesWithAverageSpeedAbove700())
                Console.WriteLine(typeName);

            // 2.25. feladat
            Console.WriteLine("\nElső 3 megfelelő repülő (min. 200 fő, 1990 után, min. 800 km/h):");
            foreach (var plane in manager.GetFirstThreeQualifyingPlanes())
                Console.WriteLine($"{plane.PlaneName} ({plane.BuiltYear})");

            // 2.26. feladat
            Console.WriteLine("\nFormázott repülőlista:");
            foreach (var line in manager.GetFormattedPlaneList())
                Console.WriteLine(line);

            // 2.27. feladat
            Console.WriteLine($"\nVan 2015 után készült, min. 300 fős, min. 900 km/h-s repülő: {manager.HasPlaneMatchingCriteria()}");

            // 2.28. feladat
            Console.WriteLine("\n3 leggyorsabb repülő típusonként:");
            foreach (var kvp in manager.GetTopThreeFastestPlanesByType())
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var plane in kvp.Value)
                    Console.WriteLine($"  {plane.PlaneName} - {plane.MaxSpeed} km/h");
            }

            // 2.29. feladat
            Console.WriteLine($"\nLegnagyobb összesített kapacitású típus: {manager.GetTypeWithLargestTotalCapacity()}");

            // 3.7. feladat
            PassengerPlane passengerOne = new("Airbus A350", 2013, 945, 13100, 350, 120000, 40, 150000);
            PassengerPlane passengerTwo = new("Boeing 787 Dreamliner", 2009, 954, 13100, 330, 110000, 36, 170000);
            Helicopter heliOne = new("Airbus H145", 2014, 268, 5200, 2, true);
            Helicopter heliTwo = new("Robinson R44", 1992, 240, 4300, 2, false);

            // 3.8 feladat
            Console.WriteLine(passengerOne.GetAge(2026));
            Console.WriteLine(passengerTwo.GetAge(2026));
            Console.WriteLine(heliOne.GetAge(2026));
            Console.WriteLine(heliTwo.GetAge(2026));
            //
            Console.WriteLine(passengerOne.IsFasterThan(500));
            Console.WriteLine(passengerTwo.IsFasterThan(500));
            Console.WriteLine(heliOne.IsFasterThan(500));
            Console.WriteLine(heliTwo.IsFasterThan(500));
            //
            Console.WriteLine(passengerOne.GetTicketPrice());
            Console.WriteLine(passengerOne.GetBusinessSeatPercentage());
            Console.WriteLine(passengerTwo.GetTicketPrice());
            Console.WriteLine(passengerTwo.GetBusinessSeatPercentage());
            //
            Console.WriteLine(heliOne.IsSuitableForRescue());
            Console.WriteLine(heliOne.GetRotorInfo());
            Console.WriteLine(heliTwo.IsSuitableForRescue());
            Console.WriteLine(heliTwo.GetRotorInfo());
            //
            passengerOne.Refuel(10000);
            Console.WriteLine(passengerOne.GetFuelAmount());
            passengerOne.ConsumeFuel(50000);
            Console.WriteLine(passengerOne.GetFuelAmount());
            Console.WriteLine(passengerOne.CalculateRevenue(280));
            //
            Console.WriteLine(passengerOne.GetVehicleInfo());
            Console.WriteLine(passengerTwo.GetVehicleInfo());
            Console.WriteLine(heliOne.GetVehicleInfo());
            Console.WriteLine(heliTwo.GetVehicleInfo());
        }
    }
    public class OneNum
    {
        public List<int> nums { get; set; }
        public void Nums()
        {
            Console.WriteLine("Adj meg számokat egy sorban, vesszővel elválasztva:");
            string input = Console.ReadLine();
            try
            {
                string[] numArray = input.Trim().Split(',');
                nums = numArray.Select(int.Parse).ToList();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
        public void Calc()
        {
            var largestNum = nums.MaxBy(x => x);
            var avgNum = nums.Average();
            var thirtyMoreNum = nums.Where(x => x > 30);
            var negativeNum = nums.Where(x => x < 0);
            int counter = 0;
            if (nums.Count < 3)
                counter = nums.Count;
            else
                counter = 3;
            var threeLNum = nums.OrderByDescending(x=>x).Take(counter).ToList();
            Console.WriteLine($"A legnagyobb szám: {largestNum}");
            Console.WriteLine($"A számok átlaga: {avgNum}");
            Console.WriteLine($"A 30-nál nagyobb számok: {thirtyMoreNum.Count()}");
            Console.WriteLine($"A negatív számok: {negativeNum.Count()}");
            Console.WriteLine($"A legnagyobb 3 szám(vagy az összes, hogyha 3-nál kevesebb szám van): {string.Join(' ',threeLNum)}");
        }

    }
}
