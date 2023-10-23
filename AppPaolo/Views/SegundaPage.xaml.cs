using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPaolo.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPage : ContentPage {
        public SegundaPage(string nombre) {
            InitializeComponent();
            Title = nombre;
        }
    }
}