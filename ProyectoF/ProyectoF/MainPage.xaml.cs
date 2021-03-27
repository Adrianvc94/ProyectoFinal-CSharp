using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            login.Clicked += Login_Clicked;
            SignIn.Clicked += SignIn_Clicked;
            BtnCuenta.Clicked += BtnCuenta_Clicked;
            BtnMarket.Clicked += BtnMarket_Clicked;
            BtnShopping.Clicked += BtnShopping_Clicked;
            BtnDescriptionPage.Clicked += BtnDescriptionPage_Clicked;
        }

        private void BtnDescriptionPage_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DescriptionPage());
        }

        private void BtnShopping_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ShoppingCart());
        }

        private void BtnMarket_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Market());
        }

        private void BtnCuenta_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Cuenta());
        }

        private void SignIn_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new SignUp());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Login());
        }
    }
}
