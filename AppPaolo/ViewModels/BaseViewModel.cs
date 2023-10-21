using AppPaolo.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppPaolo.ViewModels {
    public class BaseViewModel : INotifyPropertyChanged {

        public HttpHelper _httpHelper;
        private bool loading;

        public BaseViewModel() {
            _httpHelper = new HttpHelper();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
