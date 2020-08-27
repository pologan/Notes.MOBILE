using Notes.MOBILE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private NotesListViewModel _vm;
        public MainPage()
        {
            _vm = new NotesListViewModel();
            BindingContext = _vm;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = App.Notes;
        }
    }
}