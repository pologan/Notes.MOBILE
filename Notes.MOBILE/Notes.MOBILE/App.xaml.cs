using Notes.API.Models;
using Notes.MOBILE.Data;
using Notes.MOBILE.Views.Pages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Notes.MOBILE
{
    public partial class App : Application
    {
        public static ObservableCollection<Note> Notes { get; set; }
        public static NotesManager NotesManager { get; private set; }

        public App()
        {
            InitializeComponent();

            NotesManager = new NotesManager(new RestService());
            Notes = new ObservableCollection<Note>();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
