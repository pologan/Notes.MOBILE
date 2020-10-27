using Notes.API.Models;
using Notes.MOBILE.Views.Pages;
using Notes.MOBILE.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteView : ContentView
    {
        public NoteView()
        {
            InitializeComponent();

        }

        private async void EditClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            int id = note.Id;
            await (App.Current.MainPage as NavigationPage).PushAsync(new AddEditPage(id));
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            PopupNavigation.Instance.PushAsync(new DeletePopup 
            {
                
                YesCommand = new Command (() =>
                                   {
                                       App.Notes.Remove(note);
                                       App.NotesManager.DeleteNoteAsync(note);
                                       PopupNavigation.Instance.PopAsync();
                                   }),
                NoCommand = new Command (()=> PopupNavigation.Instance.PopAsync())
            });
        }
    }
}