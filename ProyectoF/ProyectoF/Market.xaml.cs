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
    public partial class Market : ContentPage
    {
        public Market()
        {
            InitializeComponent();
            btnCuenta.Clicked += BtnCuenta_Clicked;
            btnIP12.Clicked += BtnIP12_Clicked;
        }

        private void BtnCuenta_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Cuenta());
        }

        private void BtnIP12_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DescriptionPage());
        }
    }
}