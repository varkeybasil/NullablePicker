using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NullablePicker
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {

            var t = ClearPicker.SelectedItem;
        }

        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel = new MainPageViewModel();
        }
    }
}
