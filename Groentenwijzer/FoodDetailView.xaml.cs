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
            FoodItemTitle.Text = NavigationContext.QueryString["FoodName"];
        }
    }
}