using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Groentenwijzer
{
    public partial class FoodDetailView : PhoneApplicationPage
    {
        public FoodDetailView()
        {
            InitializeComponent();  
            Loaded += FoodDetailView_Loaded;
        }

        private void FoodDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            var foodName = NavigationContext.QueryString["FoodName"];
            FoodItemTitle.Text = foodName;
            var uriString = string.Format("http://nl.wikipedia.org/wiki/{0}", foodName);
            WebBrowser.Navigate(new Uri(uriString));
        }
    }
}