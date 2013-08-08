using System;
using System.ComponentModel;

namespace Groentenwijzer
{
    public class FoodItemViewModel : INotifyPropertyChanged
    {
        public FoodItemViewModel()
        {
        }

        public FoodItemViewModel(string name)
        {
            Name = Resource.ResourceManager.GetString(name.Replace(" ", "_")) ?? name;
            Key = name;
        }

        public string Name { get; set; }

        public string Key { get; private set; }
     
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}