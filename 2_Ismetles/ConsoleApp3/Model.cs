namespace ConsoleApp3
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public int Capacity { get; set; }
        public int MaxSpeed { get; set; }
        public int BuiltYear { get; set; }
        public int TypeId { get; set; }
    }

    public class PlaneType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }

    public class PlaneManager
    {
        public List<Plane> Planes { get; set; } = new List<Plane>();
        public List<PlaneType> PlaneTypes { get; set; } = new List<PlaneType>();

        public PlaneManager()
        {
            ReadFile();
        }

        private void ReadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines("planes.txt");
                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    int planeId = int.Parse(parts[0]);
                    string planeName = parts[1];
                    int capacity = int.Parse(parts[2]);
                    int maxSpeed = int.Parse(parts[3]);
                    int builtYear = int.Parse(parts[4]);
                    int typeId = int.Parse(parts[5]);
                    string typeName = parts[6];

                    Planes.Add(new Plane
                    {
                        PlaneId = planeId,
                        PlaneName = planeName,
                        Capacity = capacity,
                        MaxSpeed = maxSpeed,
                        BuiltYear = builtYear,
                        TypeId = typeId
                    });

                    if (!PlaneTypes.Any(t => t.TypeId == typeId))
                    {
                        PlaneTypes.Add(new PlaneType { TypeId = typeId, TypeName = typeName });
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private string GetTypeName(int typeId)
        {
            return PlaneTypes.First(t => t.TypeId == typeId).TypeName;
        }

        // 4. feladat
        public List<string> GetPlaneNamesByType(string typeName)
        {
            return Planes.Where(p => GetTypeName(p.TypeId) == typeName)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 5. feladat
        public List<string> GetPlaneNamesExistingInYear(int year)
        {
            return Planes.Where(p => p.BuiltYear <= year)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 6. feladat
        public Dictionary<string, int> GetPlaneCountByType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.Count());
        }

        // 7. feladat
        public Dictionary<string, int> GetMaxSpeedByType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.Max(p => p.MaxSpeed));
        }

        // 8. feladat
        public List<string> GetPlaneNamesWithAtLeastThreeWords()
        {
            return Planes.Where(p => p.PlaneName.Split(' ').Length >= 3)
                         .Select(p => p.PlaneName)
                         .OrderBy(name => name)
                         .ToList();
        }

        // 9. feladat
        public Dictionary<string, double> GetAverageSpeedByType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.Average(p => p.MaxSpeed));
        }

        // 10. feladat
        public List<string> GetPlaneNamesByMinCapacity(int minCapacity)
        {
            return Planes.Where(p => p.Capacity >= minCapacity)
                         .OrderBy(p => p.Capacity)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 11. feladat
        public List<string> GetFastestPlanes(int count)
        {
            return Planes.OrderByDescending(p => p.MaxSpeed)
                         .Take(count)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 12. feladat
        public List<string> GetPlaneNamesByCapacityRange(int min, int max)
        {
            return Planes.Where(p => p.Capacity >= min && p.Capacity <= max)
                         .Select(p => p.PlaneName)
                         .OrderBy(name => name)
                         .ToList();
        }

        // 13. feladat
        public List<string> GetPlaneNamesByYearAndMinSpeed(int year, int minSpeed)
        {
            return Planes.Where(p => p.BuiltYear > year && p.MaxSpeed >= minSpeed)
                         .OrderByDescending(p => p.MaxSpeed)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 14. feladat
        public string? GetLargestCapacityPlaneName(int minCapacity)
        {
            return Planes.Where(p => p.Capacity >= minCapacity)
                         .MaxBy(p => p.Capacity)?.PlaneName;
        }

        // 15. feladat
        public string? GetOldestPlaneNameByType(string typeName)
        {
            return Planes.Where(p => GetTypeName(p.TypeId) == typeName)
                         .MinBy(p => p.BuiltYear)?.PlaneName;
        }

        // 16. feladat
        public double GetAverageCapacityFromYear(int year)
        {
            return Planes.Where(p => p.BuiltYear >= year)
                         .Average(p => p.Capacity);
        }

        // 17. feladat
        public List<string> GetPlaneNamesContaining(string text)
        {
            return Planes.Where(p => p.PlaneName.ToLower().Contains(text.ToLower()))
                         .Select(p => p.PlaneName)
                         .OrderBy(name => name)
                         .ToList();
        }

        // 18. feladat
        public List<Plane> GetPlanesStartingWith(string start1, string start2)
        {
            return Planes.Where(p => p.PlaneName.StartsWith(start1) || p.PlaneName.StartsWith(start2))
                         .OrderByDescending(p => p.BuiltYear)
                         .ToList();
        }

        // 19. feladat
        public List<string> GetPlaneNamesByTypeAndMinSpeed(string typeName, int minSpeed)
        {
            return Planes.Where(p => GetTypeName(p.TypeId) == typeName && p.MaxSpeed > minSpeed)
                         .OrderByDescending(p => p.MaxSpeed)
                         .Select(p => p.PlaneName)
                         .ToList();
        }

        // 20. feladat
        public Dictionary<string, int> GetTotalCapacityByType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.Sum(p => p.Capacity));
        }

        // 21. feladat
        public Dictionary<string, string> GetLargestCapacityPlaneNamePerType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.MaxBy(p => p.Capacity).PlaneName);
        }

        // 22. feladat
        public List<Plane> GetThreeNewestPlanesWithMinCapacity()
        {
            return Planes.Where(p => p.Capacity >= 150)
                         .OrderByDescending(p => p.BuiltYear)
                         .Take(3)
                         .ToList();
        }

        // 23. feladat
        public Dictionary<string, int> GetPlaneCountByTypeAfterYear(int year)
        {
            return Planes.Where(p => p.BuiltYear > year)
                         .GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.Count());
        }

        // 24. feladat
        public List<string> GetTypesWithAverageSpeedAbove700()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .Where(g => g.Average(p => p.MaxSpeed) > 700)
                         .OrderByDescending(g => g.Average(p => p.MaxSpeed))
                         .Select(g => g.Key)
                         .ToList();
        }

        // 25. feladat
        public List<Plane> GetFirstThreeQualifyingPlanes()
        {
            return Planes.Where(p => p.Capacity >= 200 && p.BuiltYear > 1990 && p.MaxSpeed >= 800)
                         .Take(3)
                         .ToList();
        }

        // 26. feladat
        public List<string> GetFormattedPlaneList()
        {
            return Planes.OrderBy(p => p.PlaneName)
                         .Select(p => $"{p.PlaneName} - {p.Capacity} fő - {p.MaxSpeed} km/h")
                         .ToList();
        }

        // 27. feladat
        public bool HasPlaneMatchingCriteria()
        {
            return Planes.Any(p => p.BuiltYear > 2015 && p.Capacity >= 300 && p.MaxSpeed >= 900);
        }

        // 28. feladat
        public Dictionary<string, List<Plane>> GetTopThreeFastestPlanesByType()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .ToDictionary(g => g.Key, g => g.OrderByDescending(p => p.MaxSpeed).Take(3).ToList());
        }

        // 29. feladat
        public string? GetTypeWithLargestTotalCapacity()
        {
            return Planes.GroupBy(p => GetTypeName(p.TypeId))
                         .MaxBy(g => g.Sum(p => p.Capacity))
                         .Key;
        }
    }
}
