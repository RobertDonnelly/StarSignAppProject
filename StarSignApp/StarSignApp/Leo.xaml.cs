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
	public partial class Leo : ContentPage
	{
		public Leo ()
		{
			InitializeComponent ();
            AddImagesToPage();
            AddImage2ToPage();
        }

        private void AddImage2ToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.obama.jpg";

            imageObama.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.leo.jpg";

            imageLeo.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }

}