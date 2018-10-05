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
