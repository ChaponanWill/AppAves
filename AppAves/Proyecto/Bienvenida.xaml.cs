﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAves.Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bienvenida : ContentPage
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        private void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PesoGallina());
        }
    }
}