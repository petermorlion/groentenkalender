using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Groentenwijzer.SampleData;
using Microsoft.Phone.Controls;

namespace Groentenwijzer
{
    public partial class FoodByMonthView : PhoneApplicationPage
    {
        private NavigationMode _navigationMode;

        // Constructor
        public FoodByMonthView()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            this.Loaded += new RoutedEventHandler(FoodByMonthView_Loaded);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _navigationMode = e.NavigationMode;
            if (e.NavigationMode != NavigationMode.Back)
            {
                IList<FoodType> foodTypes = new List<FoodType> { FoodType.Fruit, FoodType.Vegetable };
                if (NavigationContext.QueryString.ContainsKey("FoodType"))
                {
                    var selectedFoodType = (FoodType)Enum.Parse(typeof(FoodType), NavigationContext.QueryString["FoodType"], true);
                    foodTypes = new List<FoodType> { selectedFoodType };
                }

                MainPivot.DataContext = new FoodByMonthViewModel(foodTypes, DateTime.Now.Month - 1);
            }
        }

        private void FoodItem_Click(object sender, RoutedEventArgs e)
        {
            var hyperlinkButton = (HyperlinkButton) sender;
            var foodItemViewModel = (FoodItemViewModel)hyperlinkButton.DataContext;
            var wikipediaKey = Vegetables.All().Union(Fruit.All()).Single(x => x.Name == foodItemViewModel.Key).WikipediaKey;
            var uriString = string.Format("/Groentenwijzer;component/FoodDetailView.xaml?FoodName={0}&WikipediaKey={1}", hyperlinkButton.Content, wikipediaKey);
            NavigationService.Navigate(new Uri(uriString, UriKind.Relative));
        }
    }
}