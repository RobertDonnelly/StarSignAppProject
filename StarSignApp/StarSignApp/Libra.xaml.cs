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
	public partial class Libra : ContentPage
	{
        public Libra()
        {
            InitializeComponent();
            AddImagesToPage();
            AddImage2ToPage();


        }

        private void AddImage2ToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.putin.jpeg";

            imagePutin.Source = ImageSource.FromResource(strFilename, assembly);
        }

        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.libra.jpg";

            imageLibra.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}