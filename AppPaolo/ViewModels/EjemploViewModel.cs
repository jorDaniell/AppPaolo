using AppPaolo.Models;
using AppPaolo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppPaolo.ViewModels {
    public class EjemploViewModel {

        private string color;
        public string Nombre { get; set; }
        public bool EstaApagado { get; set; }
        public ICommand PressCommand { get; set; }
        public PersonaModel Persona1{ get; set; }



        public EjemploViewModel()
        {
            Nombre = "Paolo";
            EstaApagado = true;
            color = "Verde";
            PressCommand = new Command(Press);
            Persona1 = new PersonaModel("Jorge", 36);
        }

        private async void Press() {
            //linea 1 
            //linea 2 
            await App.Current.MainPage.Navigation.PushAsync(new SegundaPage());
        }
    }
}
