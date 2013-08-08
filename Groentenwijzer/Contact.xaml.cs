using System;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace Groentenwijzer
{
    public partial class Contact : PhoneApplicationPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void TwitterButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var task = new WebBrowserTask {Uri = new Uri("http://www.twitter.com/petermorlion")};
            task.Show();
        }

        private void MailButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var task = new EmailComposeTask
                           {
                               To = "peter.morlion@live.be", 
                               Subject = Resource.ResourceManager.GetString("mailSubject")
                           };
            task.Show();
        }
    }
}