using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StarSignApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddImagesToPage();
        }

        private void btnLogin_Clicked(object sender, EventArgs obj)
        {
            Navigation.PushAsync(new HomePage());
        }
        private void AddImagesToPage()
        {
            var assembly = typeof(MainPage);


            string strFilename = "StarSignApp.NewFolder.stars.png";


            imageStars.Source = ImageSource.FromResource(strFilename, assembly);
        }
    }
}
