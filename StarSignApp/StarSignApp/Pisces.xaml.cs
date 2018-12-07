using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarSignApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pisces : ContentPage
	{
		public Pisces ()
		{
			InitializeComponent ();
            AddImagesToPage();
		}
        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.pisces.jpg";

            imagePisces.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}