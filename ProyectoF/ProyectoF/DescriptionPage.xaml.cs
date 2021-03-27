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
    public partial class DescriptionPage : ContentPage
    {
        public DescriptionPage()
        {
            InitializeComponent();
            btnBack.Clicked += BtnBack_Clicked;
            btnCarrito.Clicked += BtnCarrito_Clicked;
        }

        private void BtnCarrito_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ShoppingCart());
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Market());
        }
    }
}