using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Parcial_I
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Numero : ContentPage
    {
        public Numero()
        {
            InitializeComponent();
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
             string numero = Convert.ToString(numero01.Text);
            string numero2 = numero.Substring(0, numero.Length - 1);
            int resul, resultado = Convert.ToInt32(numero2);
            resul = resultado - 4;
            string re = Convert.ToString(resul);
            DisplayAlert("Su Numero es:", re, "Ok");
        }
    }
}