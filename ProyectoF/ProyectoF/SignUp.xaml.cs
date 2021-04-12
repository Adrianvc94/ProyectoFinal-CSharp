using ProyectoF.Modelos;
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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
            btnIrLogin.Clicked += BtnIrLogin_Clicked;
            btnSignUp.Clicked += BtnSignUp_Clicked;
            ListaUsers();
        }

        private void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            UsuarioRepositorio.Instancia.AddNewUser(usr.Text, email.Text, pwd.Text);

        }

        private void ListaUsers()
        {
            var allUsers = UsuarioRepositorio.Instancia.GetAllUsers();
            userList.ItemsSource = allUsers;
        }

        private void BtnIrLogin_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Login());
        }

    }
}