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
    public partial class Calculo : ContentPage
    {
        double c1 = 14.818;
        double c2 = 486.6;
        double peso;
        double estatura;
        double calorias;
        double ct;
        
        public Calculo()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            peso = Convert.ToDouble(txtkg.Text);
            estatura = Convert.ToDouble(txtcm.Text);
            calorias = ((c1 * peso) + c2);
            if (txtactividad.Text == "sedentario")
            {

                ct = calorias * 1.40;
                DisplayAlert("CALORIAS", "Su gasto de energía total es de " + ct.ToString() + " ", "OK");

            }
            else if (txtactividad.Text == "ligeramente activo")
            {
                ct = calorias * 1.69;
                DisplayAlert("CALORIAS", "Su gasto de energía total es de " + ct.ToString() + " ", "OK");
            }
            else if (txtactividad.Text == "moderadamente activo")
            {

                ct = calorias * 1.70;
                DisplayAlert("CALORIAS", "Su gasto de energía total es de " + ct.ToString() + " por lo tanto tiene sobrepeso", "OK");
            }
            else
            {
                ct = calorias * 2;
                DisplayAlert("CALORIAS", "Su gasto de energía total es de " + ct.ToString() + " por lo tanto sufre obesidadd", "OK");

            }

            //lblresultado.Text = "Su IMC es" + imc.ToString();
        }

        private void validar()
        {
            if (!string.IsNullOrEmpty(txtcm.Text) && !string.IsNullOrEmpty(txtkg.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }
        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}