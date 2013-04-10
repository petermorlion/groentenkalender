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

            FruitButton.Content = Resource.ResourceManager.GetString("Fruit") ?? FruitButton.Content;
            VegetablesButton.Content = Resource.ResourceManager.GetString("Groenten") ?? FruitButton.Content;
            AllButton.Content = Resource.ResourceManager.GetString("Alles") ?? FruitButton.Content;

            FruitButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Fruit", UriKind.Relative));
            VegetablesButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Vegetable", UriKind.Relative));
            AllButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml", UriKind.Relative));
        }
    }
}