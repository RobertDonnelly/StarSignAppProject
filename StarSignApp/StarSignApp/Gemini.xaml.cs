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
	public partial class Gemini : ContentPage
	{
		public Gemini ()
		{
			InitializeComponent ();
            AddImagesToPage();
		}

        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);

            string strFilename = "StarSignApp.NewFolder.gemini.jpg";
            imageGemini.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}