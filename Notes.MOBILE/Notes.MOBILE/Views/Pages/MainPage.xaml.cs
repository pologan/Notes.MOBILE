using Notes.API.Models;
using Notes.MOBILE.ViewModels;
using System;

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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _vm.RefreshNotes();

            listView.ItemsSource = App.Notes;
        }

        private async void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Note;
            await Navigation.PushAsync(new DetailPage(item.Id), true);
        }

        private async void AddNewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEditPage());
        }
    }
}