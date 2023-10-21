using AppPaolo.Models.Login;
using AppPaolo.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppPaolo.ViewModels {
    public class LoginViewModel : BaseViewModel {

        public LoginModel DatosLogin { get; set; } = new LoginModel();
        public ICommand ValidarCommand { get; set; }

        public LoginViewModel() {
            ValidarCommand = new Command(Validar);
        }

        private async void Validar() {
            if(ValidarNoCadenaVacias()) {
                Login();
            } else {
                await App.Current.MainPage.DisplayAlert("", "Datos vacios", "ok");
            }
        }

        private async void Login() {
            LoginResponse response = await _httpHelper.PostLoginAsync(DatosLogin);

            if(response is null) { //datos incorrectos
                await App.Current.MainPage.DisplayAlert("", "Datos incorrectos", "ok");
            } else { //Datos correctos 
                await App.Current.MainPage.Navigation.PushAsync(new SegundaPage());
            }
        }

        private bool ValidarNoCadenaVacias() {
            if(string.IsNullOrEmpty(DatosLogin.Email) || string.IsNullOrEmpty(DatosLogin.Password)) {
                return false;
            }
            return true;
        }
    }
}
