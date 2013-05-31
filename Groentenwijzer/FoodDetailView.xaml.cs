using System;
using System.Globalization;
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
            
            var wikipediaBaseUriString = Resource.ResourceManager.GetString("wikipediaBaseUri");
            var uriString = string.Format(wikipediaBaseUriString, wikipediaKey);
            WebBrowser.Navigate(new Uri(uriString));
        }
    }
}