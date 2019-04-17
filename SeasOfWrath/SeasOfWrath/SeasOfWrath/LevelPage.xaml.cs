using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeasOfWrath
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LevelPage : ContentPage
	{
		public LevelPage ()
		{
			InitializeComponent ();
		}

        private async void LevelOneButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LevelOne());
        }
        
        private async void LevelTwoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LevelTwo());
        }

        private async void DeveloperLevelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DevLevelPage());
        }
    }
}