using System.Collections.Generic;

namespace Groentenwijzer.SampleData
{
    public static class Fruit
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
                           new FoodItem { Name = "Aardbeien", Months = new List<int> { 5, 6, 7, 8 } },
                           new FoodItem { Name = "Abrikozen", Months = new List<int> { 6, 7, 8 } },
                           new FoodItem { Name = "Appelen", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Bananen", Months = new List<int> { 1, 2, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Bramen", Months = new List<int> { 7, 8, 9, 10 } },
                           new FoodItem { Name = "Druiven", Months = new List<int> { 8, 9, 10, 11 } },
                           new FoodItem { Name = "Frambozen", Months = new List<int> { 6, 7, 8, 9, 10 } },
                           new FoodItem { Name = "Kersen", Months = new List<int> { 6, 7, 8 } },
                           new FoodItem { Name = "Kiwi's", Months = new List<int> { 9, 10, 11, 12 } },
                           new FoodItem { Name = "Mandarijnen", Months = new List<int> { 1, 2, 10, 11, 12 } },
                           new FoodItem { Name = "Mango", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Meloenen", Months = new List<int> { 8, 9, 10 } },
                           new FoodItem { Name = "Nectarines", Months = new List<int> { 6, 7, 8, 9 } },
                           new FoodItem { Name = "Peren", Months = new List<int> { 1, 2, 8, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Perziken", Months = new List<int> { 6, 7, 8, 9 } },
                           new FoodItem { Name = "Pompelmoes", Months = new List<int> { 1, 2, 3, 4, 5, 9, 10, 11, 12 } },
                           new FoodItem { Name = "Pruimen", Months = new List<int> { 8, 9 } },
                           new FoodItem { Name = "Rabarber", Months = new List<int> { 3, 4, 5, 6, 7 } },
                           new FoodItem { Name = "Rode bessen", Months = new List<int> { 6, 7 } },
                           new FoodItem { Name = "Sinaasappelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 10, 11, 12 } },
                           new FoodItem { Name = "Zwarte bessen", Months = new List<int> { 6, 7, 8 } }
                       };
        }
    }
}