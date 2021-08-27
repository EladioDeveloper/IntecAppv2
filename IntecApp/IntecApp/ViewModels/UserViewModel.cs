using IntecApp.Models;
using IntecApp.Services;
using IntecApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IntecApp.ViewModels
{
    public class UserViewModel
    {
        private IAlertService _alertService;
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; }
        public ICommand NavigateCommand { get; }
        public ICommand SignUpCommand { get; }

        public UserViewModel(IAlertService alertService)
        {
            _alertService = alertService;
            //LoginCommand = new Command<User>(Login);

            LoginCommand = new Command(async () =>
            {
                if (String.IsNullOrEmpty(User.Email) || String.IsNullOrEmpty(User.Password))
                    await alertService.Alert("Error", "Campos Vacios", "OK");
                else
                {
                    await alertService.Alert("Bienvenido", $"Hola {User.Email}", "OK");
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }
            });

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            });


            SignUpCommand = new Command(async () =>
            {
                if (
                String.IsNullOrEmpty(User.Name) ||
                String.IsNullOrEmpty(User.Email) ||
                String.IsNullOrEmpty(User.Password) ||
                String.IsNullOrEmpty(User.ConfirmPassword))
                    await alertService.Alert("Error", "Campos Vacios", "OK");
                else if (User.Password.ToString().Equals(User.ConfirmPassword.ToString()))
                    await alertService.Alert("Bienvenido", $"Hola {User.Email}", "OK");
                else
                    await alertService.Alert("Error", "Contraseñas no coinciden", "OK");
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;


        // No me quiso funcioanr asi :( consultar en clases
        private async void Login(User User)
        {
            if (String.IsNullOrEmpty(User.Email) || String.IsNullOrEmpty(User.Password))
                await _alertService.Alert("Error", "Campos Vacios", "OK");
            else
                await _alertService.Alert("Bienvenido", $"Hola {User.Email}", "OK");
        }
    }
}
