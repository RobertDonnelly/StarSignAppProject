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
        private void btnStarSign_Clicked(object sender, EventArgs obj)
        {
            double day = Convert.ToDouble(EntryDay.Text);
            double month = Convert.ToDouble(EntryMonth.Text);

            // calculating which star sign the user is!
            //im using two if statements per star sign
            //AQUARIUS
            if (month == 1 && day >= 20 && day <= 31)
            {
                yourSign.Text = "You Are an Aquarius!";
            }
            else if (month == 2 && day <= 18)
            {
                yourSign.Text = "You Are an Aquarius!";
            }
            //PISCES
            else if (month == 2 && day > 18 && day <= 28)
            {
                yourSign.Text = "You Are a Pisces!";
            }
            else if (month == 3 && day <= 20)
            {
                yourSign.Text = "You Are a Pisces!";
            }
            //ARIES
            else if (month == 3 && day > 20 && day <= 31)
            {
                yourSign.Text = "You Are a Aries!";
            }
            else if (month == 4 && day < 20)
            {
                yourSign.Text = "You Are a Aries!";
            }
            //TAURUS
            else if (month == 4 && day < 31 && day >= 21)
            {
                yourSign.Text = "You Are a Taurus!";
            }
            else if (month == 5 && day < 21)
            {
                yourSign.Text = "You Are a Taurus!";
            }
            //GEMINI
            else if (month == 5 && day <= 31 && day >= 21)
            {
                yourSign.Text = "You Are a Gemini!";
            }
            else if (month == 6 && day < 21)
            {
                yourSign.Text = "You Are a Gemini!";
            }
            //CANCER
            else if (month == 6 && day >= 21 && day <= 30)
            {
                yourSign.Text = "You Are a Cancer!";
            }
            else if (month == 7 && day < 23)
            {
                yourSign.Text = "You Are a Cancer!";
            }
            //LEO
            else if (month == 7 && day >= 23 && day <= 31)
            {
                yourSign.Text = "You Are a Leo!";
            }
            else if (month == 8 && day < 23)
            {
                yourSign.Text = "You Are a Leo!";
            }
            //VIRGO
            else if (month == 8 && day >= 23 && day <= 31)
            {
                yourSign.Text = "You Are a Virgo!";
            }
            else if (month == 9 && day < 23)
            {
                yourSign.Text = "You Are a Virgo!";
            }
            //LIBRA
            else if (month == 9 && day >= 23 && day <= 30)
            {
                yourSign.Text = "You Are a Libra!";
            }
            else if (month == 10 && day < 23)
            {
                yourSign.Text = "You Are a Libra!";
            }
            //SCORPIO
            else if (month == 10 && day >= 23 && day <= 31)
            {
                yourSign.Text = "You Are a Scorpio!";
            }
            else if (month == 11 && day < 22)
            {
                yourSign.Text = "You Are a Scorpio!";
            }
            //SAGITTARIUS
            else if (month == 11 && day >= 22 && day <= 30)
            {
                yourSign.Text = "You Are a Sagittarius!";
            }
            else if (month == 12 && day < 22)
            {
                yourSign.Text = "You Are a Sagittarius!";
            }
            //CAPRICORN
            else if(month == 12 && day >=22 && day <=31)
            {
                yourSign.Text = "You Are a Capricprn!";
            }
            else if(month == 1 && day <20)
            {
                yourSign.Text = "You Are a Capricorn!";
            }
            else
            {
                yourSign.Text = "That is not a real date Try Again!";
            }

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
