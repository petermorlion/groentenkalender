using System.Collections.Generic;

namespace Groentenwijzer.SampleData
{
    public static class Vegetables
    {
        public static IList<Vegetable> All()
        {
            return new List<Vegetable>
                       {
                           new Vegetable { Name = "Aardappelen", Months = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12 } },
                           new Vegetable { Name = "Andijvie", Months = new List<int> { 4 } },
                           new Vegetable { Name = "Bloemkool", Months = new List<int> { 3, 4 } },
                           new Vegetable { Name = "Groene selder", Months = new List<int> { 2, 3, 4 } },
                           new Vegetable { Name = "Knolselder", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Paddenstoelen", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Pastinaak", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Pompoen", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Prei", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Raap", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Raapstelen", Months = new List<int> { 4 } },
                           new Vegetable { Name = "Radijs", Months = new List<int> { 3, 4 } },
                           new Vegetable { Name = "Rammenas", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Rode biet", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Rodekool", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Savooikool", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Schorseneren", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Spinazie", Months = new List<int> { 3, 4 } },
                           new Vegetable { Name = "Spruiten", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Uien", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Veldsla", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Witlof", Months = new List<int> { 1, 2, 3, 4 } },
                           new Vegetable { Name = "Wittekool", Months = new List<int> { 1, 2, 3 } },
                           new Vegetable { Name = "Wortelen", Months = new List<int> { 1, 2, 3 } },
                       };
        }
    }
}