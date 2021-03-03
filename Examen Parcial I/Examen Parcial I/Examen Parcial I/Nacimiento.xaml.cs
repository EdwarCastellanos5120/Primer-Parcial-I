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
    public partial class Nacimiento : ContentPage
    {
        public Nacimiento()
        {
            InitializeComponent();
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
           int  resta, dia = Convert.ToInt32(n01.Text);
            string resul;
            resta = dia - 365;
            if (resta <= 1000)
            {
                string nuevo = Convert.ToString(resta);
                string n2 = nuevo.Substring(1, 2);
                resul=("Su dia es: " + nuevo[0]+ " Su numero de mes : " + n2);
            }
            else
            {
                string nuevo = Convert.ToString(resta);
                string n1 = nuevo.Substring(0, 2);
                string n2 = nuevo.Substring(2, 2);
                resul=("Su dia es: " + n1+ " Su numero de mes : " + n2);
            }
            DisplayAlert("Su Fecha de N", resul, "Ok");
        }
    }
}