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
	public partial class Cancer : ContentPage
	{
		public Cancer ()
		{
			InitializeComponent ();
            AddImagesToPage();
            AddImage2ToPage();

        }

        private void AddImage2ToPage()
        {
            var assembly = typeof(MainPage);

            string strFilename = "StarSignApp.NewFolder.elon.jpg";
            imageElon.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);

            string strFilename = "StarSignApp.NewFolder.cancer.jpg";
            imageCancer.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}