using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActualizarProyecto.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateData : ContentPage
    {
        private string _mask = "";
        public string Mask
        {
            get => _mask;
            set
            {
                _mask = value;
            }
        }
        public UpdateData()
        {
            InitializeComponent();
        }
    }
}