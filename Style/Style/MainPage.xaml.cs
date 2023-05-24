using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Style
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(apka.Style == (Xamarin.Forms.Style)Resources["jasny"])
            {
                apka.Style = (Xamarin.Forms.Style)Resources["ciemny"];
            }else apka.Style = (Xamarin.Forms.Style)Resources["jasny"];


        }
    }
}
