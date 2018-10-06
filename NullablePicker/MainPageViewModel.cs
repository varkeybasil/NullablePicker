using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace NullablePicker
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        List<string> countries = new List<string>
    {
        "Afghanistan",
        "Albania",
        "Algeria",
        "Andorra",
        "Angola"
    };


        public string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<string> Countries => countries;
        public MainPageViewModel()
        {
        }
    }
}
