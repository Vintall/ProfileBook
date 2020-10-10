using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfileBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInView : ContentView
    {
        public SignInView()
        {
            InitializeComponent();
        }

        private void password_field_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_field_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sign_in_button_Pressed(object sender, EventArgs e)
        {
            
        }

    }
}