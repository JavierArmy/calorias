using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calorias.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuCaratula : ContentPage
    {
        public MenuCaratula()
        {
            InitializeComponent();
        }
        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculo());
        }
    }
}