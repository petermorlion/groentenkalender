using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Groentenwijzer.SampleData;

namespace Groentenwijzer
{
    public class FoodByMonthViewModel : INotifyPropertyChanged
    {
        private int _selectedMonth;
        private IEnumerable<FoodType> _foodTypes;

        public FoodByMonthViewModel(IEnumerable<FoodType> foodTypes)
        {
            _foodTypes = foodTypes;
            _selectedMonth = DateTime.Now.Month - 1;
        }

        public ObservableCollection<MonthViewModel> AllMonths
        {
            get
            {
                return new ObservableCollection<MonthViewModel>
                           {
                               new MonthViewModel("Januari", GetFood(1)),
                               new MonthViewModel("Februari", GetFood(2)),
                               new MonthViewModel("Maart", GetFood(3)),
                               new MonthViewModel("April", GetFood(4)),
                               new MonthViewModel("Mei", GetFood(5)),
                               new MonthViewModel("Juni", GetFood(6)),
                               new MonthViewModel("Juli", GetFood(7)),
                               new MonthViewModel("Augustus", GetFood(8)),
                               new MonthViewModel("September", GetFood(9)),
                               new MonthViewModel("Oktober", GetFood(10)),
                               new MonthViewModel("November", GetFood(11)),
                               new MonthViewModel("December", GetFood(12))
                           };
            }
        }

        private IEnumerable<FoodItem> GetFood(int month)
        {
            var result = new List<FoodItem>();

            if (_foodTypes.Contains(FoodType.Vegetable))
            {
                result.AddRange(Vegetables.All().Where(x => x.Months.Contains(month)));
            }

            if (_foodTypes.Contains(FoodType.Fruit))
            {
                result.AddRange(Fruit.All().Where(x => x.Months.Contains(month)));
            }

            return result;
        }

        public int SelectedMonth
        {
            get { return _selectedMonth; }
            set
            {
                if (_selectedMonth != value)
                {
                    _selectedMonth = value;
                    OnPropertyChanged("SelectedMonth");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}