using System;
using Groentenwijzer.SampleData;
using Microsoft.Phone.Controls;

namespace Groentenwijzer
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Fruit.Initialize();
            Vegetables.Initialize();
        }

        private void ListBox_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CategoriesListBox.SelectedItem == FruitItem)
            {
                NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Fruit", UriKind.Relative));
            }
            else if (CategoriesListBox.SelectedItem == VegetablesItem)
            {
                NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Vegetable", UriKind.Relative));
            }
            else if (CategoriesListBox.SelectedItem == AllItem)
            {
                NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml", UriKind.Relative));
            }
        }
    }
}