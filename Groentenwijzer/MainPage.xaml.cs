using System;
using Groentenwijzer.SampleData;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Groentenwijzer
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Fruit.Initialize();
            Vegetables.Initialize();

            foreach (ApplicationBarIconButton button in this.ApplicationBar.Buttons)
            {
                button.Text = Resource.ResourceManager.GetString(button.Text) ?? button.Text;
            }

            FruitButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Fruit", UriKind.Relative));
            VegetablesButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Vegetable", UriKind.Relative));
            AllButton.Click += (s, e) => NavigationService.Navigate(new Uri("/Groentenwijzer;component/FoodByMonthView.xaml", UriKind.Relative));
        }

        private void OnAboutIconClicked(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Groentenwijzer;component/About.xaml", UriKind.Relative));
        }

        private void OnRateIconClicked(object sender, EventArgs e)
        {
            var task = new MarketplaceReviewTask();
            task.Show();
        }

        private void OnContactIconClicked(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Groentenwijzer;component/Contact.xaml", UriKind.Relative));
        }
    }
}