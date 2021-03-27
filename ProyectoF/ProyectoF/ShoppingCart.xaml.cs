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
    public partial class ShoppingCart : ContentPage
    {
        public ShoppingCart()
        {
            InitializeComponent();
            btnBack.Clicked += BtnBack_Clicked1;
        }

        private void BtnBack_Clicked1(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DescriptionPage());
        }

    }
}