using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ProfileBook.ViewModels
{
    public class SignInViewViewModel
    {
        INavigationService navigationService;
        public SignInViewViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }

}