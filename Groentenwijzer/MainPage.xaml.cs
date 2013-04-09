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
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Groentenwijzer
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            FruitHyperlinkButton.NavigateUri = new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Fruit", UriKind.Relative);
            VegetablesHyperlinkButton.NavigateUri = new Uri("/Groentenwijzer;component/FoodByMonthView.xaml?FoodType=Vegetable", UriKind.Relative);
            AllHyperlinkButton.NavigateUri = new Uri("/Groentenwijzer;component/FoodByMonthView.xaml", UriKind.Relative);
        }
    }
}