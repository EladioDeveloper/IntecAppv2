using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntecApp.Models
{
    public class User: INotifyPropertyChanged
    {
        public User()
        {
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
