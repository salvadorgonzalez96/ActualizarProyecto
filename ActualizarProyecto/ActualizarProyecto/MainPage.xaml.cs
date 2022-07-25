using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActualizarProyecto.Pantallas;
using Xamarin.Forms;


namespace ActualizarProyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Updt_Clicked(object sender, EventArgs e)
        {
            UpdateData updt = new UpdateData();
            await Navigation.PushAsync(updt);
        }
    }
}
