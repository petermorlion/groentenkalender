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
            var wikipediaKey = NavigationContext.QueryString["WikipediaKey"];
            FoodItemTitle.Text = foodName;
            // TODO: parameterize nl, so fr can be added
            var uriString = string.Format("http://nl.wikipedia.org/wiki/{0}", wikipediaKey);
            WebBrowser.Navigate(new Uri(uriString));
        }
    }
}