﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Groentenwijzer.SampleData;

namespace Groentenwijzer
{
    public class MonthViewModel : INotifyPropertyChanged
    {
        private string _name;
        
        /// <remarks>Apparently, binding to Name doesn't work.</remarks>
        public override string ToString()
        {
            return Name;
        }

        public MonthViewModel()
        {
        }

        public MonthViewModel(string monthName, IEnumerable<FoodItem> food)
        {
            Name = Resource.ResourceManager.GetString(monthName.Replace(" ", "_")) ?? monthName;

            var foodList = new List<FoodItemViewModel>();
            foreach (var foodItem in food)
            {
                foodList.Add(new FoodItemViewModel(foodItem.Name));
            }

            FoodItems = new ObservableCollection<FoodItemViewModel>(foodList.OrderBy(x => x.Name));
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public ObservableCollection<FoodItemViewModel> FoodItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}