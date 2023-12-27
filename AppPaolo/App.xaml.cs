using AppPaolo.Views.Bio;
using Xamarin.Forms;

namespace AppPaolo {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new BioPage());
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
