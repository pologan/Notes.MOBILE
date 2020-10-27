using Notes.API.Models;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Notes.MOBILE.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class NotesListViewModel 
    {
        public NotesListViewModel()
        {
           
        }

        public async Task RefreshNotes()
        {
            App.Notes = new ObservableCollection<Note>(await App.NotesManager.GetAllNotesAsync());
        }
    }
}
