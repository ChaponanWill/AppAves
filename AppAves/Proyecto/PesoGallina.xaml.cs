using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAves.Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PesoGallina : ContentPage
    {
        
        public PesoGallina()
        {
            InitializeComponent();
        }

        private void BtnResultado_Clicked(object sender, EventArgs e)
        {
            // Salir del método si no se eligió una opción en la edad de la gallina
            if (picker.SelectedItem == null)
            {
               DisplayAlert("Alerta", "Por favor, seleccione la edad de la gallina", "Aceptar");
                return; 
            }

            string edadSeleccionada = picker.SelectedItem.ToString();
            double peso;
            string Respuesta = "";
            //Si se introduce un tipo de dato que no sea 'double' o esté vació que salga del método
            if (!double.TryParse(TxtPeso.Text, out peso))
            {
                DisplayAlert("Alerta", "Por favor, introduzca un peso válido", "Aceptar");
                return; // Salir del método si el peso no es válido
            }
            if (edadSeleccionada == "4 a 6 meses")
            {
                if (peso < 1400)
                {
                    Respuesta = "C";
                }
                else if (peso <1500)
                {
                    Respuesta = "B";
                }
                else
                {
                    Respuesta = "A";
                }
            }
            else if (edadSeleccionada == "Más de 7 meses")
            {
                if (peso < 1600)
                {
                    Respuesta = "C";
                }
                else if (peso < 1700)
                {
                    Respuesta = "B";
                }
                else
                {
                    Respuesta = "A";
                }
            }
            else
            {
                DisplayAlert("Upps!", "Selecciona una edad", "OK");
            }
            //Evaluar lo que contiene respuesta para enviarnos a la página según corresponda
            if (Respuesta == "A")
            {
                Navigation.PushAsync(new CorralA());
            }
            else if(Respuesta == "B")
            {
                Navigation.PushAsync(new CorralB());
            }
            else if(Respuesta == "C")
            {
                Navigation.PushAsync(new CorralC());
            }
    }

        private void BtnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}