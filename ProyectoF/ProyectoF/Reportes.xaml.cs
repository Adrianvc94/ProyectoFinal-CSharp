using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reportes : ContentPage
    {
        public Reportes()
        {
            InitializeComponent();          
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Mostrando compras totales";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Mostrando compras activas";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Mostrando compras canceladas";
        }
    }
}