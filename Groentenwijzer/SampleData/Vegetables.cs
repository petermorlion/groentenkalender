using System.Collections.Generic;

namespace Groentenwijzer.SampleData
{
    public static class Vegetables
    {
        private static IList<FoodItem> _data; 

        public static IList<FoodItem> All()
        {
            if (_data == null)
            {
                Initialize();
            }

            return _data;
        }

        public static void Initialize()
        {
            _data = new List<FoodItem>
                       {
                           new FoodItem { Name = "Aardappelen", Months = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Andijvie", Months = new List<int> { 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Artisjok", Months = new List<int> { 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Asperges", Months = new List<int> { 5, 6 } },
                           new FoodItem { Name = "Aubergine", Months = new List<int> { 7, 8, 9, 10 } },
                           new FoodItem { Name = "Bleekselder", Months = new List<int> { 7, 8, 9, 10, 11 } },
                           new FoodItem { Name = "Bloemkool", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11 } },
                           new FoodItem { Name = "Broccoli", Months = new List<int> { 6, 7, 8, 9, 10, 11 } },
                           new FoodItem { Name = "Chinese kool", Months = new List<int> { 7, 8, 9, 10, 11 } },
                           new FoodItem { Name = "Courgette", Months = new List<int> { 7, 8, 9, 10, 11 } },
                           new FoodItem { Name = "Doperwtjes", Months = new List<int> { 5, 6, 7 } },
                           new FoodItem { Name = "Groene selder", Months = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Knolselder", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Komkommer", Months = new List<int> { 7, 8, 9 } },
                           new FoodItem { Name = "Koolrabi", Months = new List<int> { 5, 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Kropsla", Months = new List<int> { 5, 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Maïs", Months = new List<int> { 8, 9 } },
                           new FoodItem { Name = "Paddenstoelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Paprika", Months = new List<int> { 7, 8, 9, 10 } },
                           new FoodItem { Name = "Pastinaak", Months = new List<int> { 1, 2, 3, 10, 11, 12 } },
                           new FoodItem { Name = "Pompoen", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Prei", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Prinsessenbonen", Months = new List<int> { 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Raap", Months = new List<int> { 1, 2, 3, 4, 5, 6, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Raapstelen", Months = new List<int> { 4, 5, 8, 9, 10 } },
                           new FoodItem { Name = "Radijs", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Rammenas", Months = new List<int> { 1, 2, 3, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Rode biet", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Rodekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Savooikool", Months = new List<int> { 1, 2, 3, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Schorseneren", Months = new List<int> { 1, 2, 3, 10, 11, 12 } },
                           new FoodItem { Name = "Snijbonen", Months = new List<int> { 7, 8, 9, 10 } },
                           new FoodItem { Name = "Spinazie", Months = new List<int> { 3, 4, 5, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Spitskool", Months = new List<int> { 5, 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Spruiten", Months = new List<int> { 1, 2, 3, 10, 11, 12 } },
                           new FoodItem { Name = "Tomaten", Months = new List<int> { 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Uien", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Veldsla", Months = new List<int> { 1, 2, 3, 10, 11, 12 } },
                           new FoodItem { Name = "Venkel", Months = new List<int> { 6, 7, 9, 10, 11 } },
                           new FoodItem { Name = "Warmoes", Months = new List<int> { 5, 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Witlof", Months = new List<int> { 1, 2, 3, 4, 10, 11, 12 } },
                           new FoodItem { Name = "Wittekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Wortelen", Months = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 } },
                       };
        }
    }
}