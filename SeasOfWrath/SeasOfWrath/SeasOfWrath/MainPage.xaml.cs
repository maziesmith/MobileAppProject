using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeasOfWrath
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LevelPage());
        }

        private void WinsButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
