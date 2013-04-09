using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Groentenwijzer.SampleData;
using Microsoft.Phone.Controls;

namespace Groentenwijzer
{
    public partial class FoodByMonthView : PhoneApplicationPage
    {
        // Constructor
        public FoodByMonthView()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            this.Loaded += new RoutedEventHandler(FoodByMonthView_Loaded);
        }

        // Load data for the ViewModel Items
        private void FoodByMonthView_Loaded(object sender, RoutedEventArgs e)
        {
            IList<FoodType> foodTypes = new List<FoodType> { FoodType.Fruit, FoodType.Vegetable };
            if (NavigationContext.QueryString.ContainsKey("FoodType"))
            {
                var selectedFoodType = (FoodType)Enum.Parse(typeof(FoodType), NavigationContext.QueryString["FoodType"], true);
                foodTypes = new List<FoodType> { selectedFoodType };
            }

            MainPivot.DataContext = new FoodByMonthViewModel(foodTypes);
        }
    }
}