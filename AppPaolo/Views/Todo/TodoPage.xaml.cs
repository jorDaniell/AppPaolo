using AppPaolo.ViewModels.Todo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPaolo.Views.Todo {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoPage : ContentPage {
        public TodoPage() {
            InitializeComponent();
            BindingContext = new TodoViewModel();
        }
    }
}