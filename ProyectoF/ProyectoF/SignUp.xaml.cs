﻿using ProyectoF.Modelos;
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
            StatusMessage.Text = string.Empty;
            UsuarioRepositorio.Instancia.AddNewUser(usr.Text, email.Text, pwd.Text);
            StatusMessage.Text = UsuarioRepositorio.Instancia.EstadoMensaje;

        }

        private void ListaUsers()
        {
            var allUsers = UsuarioRepositorio.Instancia.GetAllUsers();
            userList.ItemsSource = allUsers;
            StatusMessage.Text = UsuarioRepositorio.Instancia.EstadoMensaje;
        }

        private void BtnIrLogin_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Login());
        }

    }
}