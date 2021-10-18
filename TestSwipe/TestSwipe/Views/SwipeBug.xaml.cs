using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSwipe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeBug : ContentPage
    {
        public SwipeBug()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            DisplayAlert("Hi!", "SwipeGestureRecognizer_Swiped", "Ok");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Hi!", "TapGestureRecognizer_Tapped", "Ok");
        }

        private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hi!", "ClickGestureRecognizer_Clicked", "Ok");
        }
    }
}