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
	public partial class Aries : ContentPage
	{
		public Aries ()
		{
			InitializeComponent ();
            AddImage1ToPage();
            AddImage2ToPage();

		}

        private void AddImage2ToPage()
        {
            var assembly = typeof(MainPage);

            string strFilename2 = "StarSignApp.NewFolder.davinci.jpg";

            imageVinci.Source = ImageSource.FromResource(strFilename2, assembly);

        }

        private void AddImage1ToPage()
        {
            var assembly = typeof(MainPage);

            string strFilename1 = "StarSignApp.NewFolder.aries.png";

            imageAries.Source = ImageSource.FromResource(strFilename1, assembly);

        }
    }
}