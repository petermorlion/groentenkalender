using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Groentenwijzer.SampleData;

namespace Groentenwijzer
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _selectedMonth;

        public MainViewModel()
        {
            _selectedMonth = DateTime.Now.Month - 1;
        }

        public ObservableCollection<MonthViewModel> AllMonths
        {
            get
            {
                return new ObservableCollection<MonthViewModel>
                           {
                               new MonthViewModel("Januari", Vegetables.All().Where(x => x.Months.Contains(1)), Fruit.All().Where(x => x.Months.Contains(1))),
                               new MonthViewModel("Februari", Vegetables.All().Where(x => x.Months.Contains(2)), Fruit.All().Where(x => x.Months.Contains(2))),
                               new MonthViewModel("Maart", Vegetables.All().Where(x => x.Months.Contains(3)), Fruit.All().Where(x => x.Months.Contains(3))),
                               new MonthViewModel("April",  Vegetables.All().Where(x => x.Months.Contains(4)), Fruit.All().Where(x => x.Months.Contains(4))),
                               new MonthViewModel("Mei",Vegetables.All().Where(x => x.Months.Contains(5)), Fruit.All().Where(x => x.Months.Contains(5))),
                               new MonthViewModel("Juni", Vegetables.All().Where(x => x.Months.Contains(6)), Fruit.All().Where(x => x.Months.Contains(6))),
                               new MonthViewModel("Juli", Vegetables.All().Where(x => x.Months.Contains(7)), Fruit.All().Where(x => x.Months.Contains(7))),
                               new MonthViewModel("Augustus", Vegetables.All().Where(x => x.Months.Contains(8)), Fruit.All().Where(x => x.Months.Contains(8))),
                               new MonthViewModel("September", Vegetables.All().Where(x => x.Months.Contains(9)), Fruit.All().Where(x => x.Months.Contains(9))),
                               new MonthViewModel("Oktober", Vegetables.All().Where(x => x.Months.Contains(10)), Fruit.All().Where(x => x.Months.Contains(10))),
                               new MonthViewModel("November", Vegetables.All().Where(x => x.Months.Contains(11)), Fruit.All().Where(x => x.Months.Contains(11))),
                               new MonthViewModel("December", Vegetables.All().Where(x => x.Months.Contains(12)), Fruit.All().Where(x => x.Months.Contains(12)))
                           };
            }
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