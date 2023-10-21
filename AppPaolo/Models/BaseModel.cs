using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppPaolo.Models {
    public class BaseModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
