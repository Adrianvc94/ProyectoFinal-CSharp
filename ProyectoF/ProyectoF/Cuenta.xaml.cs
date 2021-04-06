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
    public partial class Cuenta : ContentPage
    {
        public Cuenta()
        {
            InitializeComponent();
            btnReportes.Clicked += BtnReportes_Clicked;
        }

        private void BtnReportes_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Reportes());
        }
    }
}