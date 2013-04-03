using System;
using System.ComponentModel;

namespace Groentenwijzer
{
    public class VegetableViewModel : INotifyPropertyChanged
    {
        public VegetableViewModel()
        {
        }

        public VegetableViewModel(string name)
        {
            Name = Resource.ResourceManager.GetString(name.Replace(" ", "_")) ?? name;
        }

        public string Name { get; set; }
     
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}