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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if ((txtCorreo.Text == "admin") && (txtPassword.Text == "admin")) 
            {
                ((NavigationPage)this.Parent).PushAsync(new Market());
            }
        }
    }
}