using AppPaolo.Views;
using AppPaolo.Views.Todo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPaolo {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new TodoPage());
        }

        protected override void OnStart() {
        }

        protected override void OnSleep() {
        }

        protected override void OnResume() {
        }
    }
}
