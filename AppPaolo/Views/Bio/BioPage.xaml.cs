using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPaolo.Views.Bio {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BioPage : ContentPage {

        public BioPage() {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e) {
            AuthenticationType authenticationType = await CrossFingerprint.Current.GetAuthenticationTypeAsync();// GetAvailabilityAsync();
           
            lblStatus.Text = authenticationType.ToString();
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e) {
            var result = await CrossFingerprint.Current.AuthenticateAsync(new AuthenticationRequestConfiguration("title", "reasons"));

            if(result.Authenticated) {
                lblAuth.Text = "Autenticado";
            } else {
                lblAuth.Text = "Error al autenticar";
            }
        }
    }
}