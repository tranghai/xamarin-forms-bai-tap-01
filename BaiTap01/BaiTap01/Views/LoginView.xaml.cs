using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (username == "admin" && password == "admin") {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainView(), this);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Login", "Username or password incorrect", "Close");
                txtPassword.Text = string.Empty;
            }
        }
    }
}