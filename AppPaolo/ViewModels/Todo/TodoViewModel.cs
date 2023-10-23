using AppPaolo.Models.Todo;
using AppPaolo.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppPaolo.ViewModels.Todo {
    public class TodoViewModel : BaseViewModel {

        public ObservableCollection<TodoModel> TodoList { get; set; }
        public TodoModel ElementoSeleccionado { get; set; }
        public ICommand SelectedItemCommand { get; set; }

        public TodoViewModel() {
            InitValues();
            SelectedItemCommand = new Command<string>(SelectedItem);
        }

        private async void InitValues() {

            List<TodoModel> list = await _httpHelper.GetTodoList();

            TodoList = new ObservableCollection<TodoModel>(list);
        }

        private async void SelectedItem(string nombre) {

            await App.Current.MainPage.Navigation.PushAsync(new SegundaPage(nombre));
        }

    }
}
