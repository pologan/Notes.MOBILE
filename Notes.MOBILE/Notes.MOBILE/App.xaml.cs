using Notes.MOBILE.Models.DTOs;
using Notes.MOBILE.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE
{
    public partial class App : Application
    {
        public static ObservableCollection<NoteDTO> Notes { get; set; } 
        public App()
        {
            InitializeComponent();

            Notes = new ObservableCollection<NoteDTO>();
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
