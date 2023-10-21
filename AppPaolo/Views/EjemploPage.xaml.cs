﻿using AppPaolo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPaolo.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EjemploPage : ContentPage {
        public EjemploPage() {
            InitializeComponent();
            BindingContext = new EjemploViewModel();
        }
    }
}