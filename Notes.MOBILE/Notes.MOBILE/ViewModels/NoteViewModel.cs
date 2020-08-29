using Notes.MOBILE.Models.DTOs;
using System;
using System.Linq;

namespace Notes.MOBILE.ViewModels
{
    public class NoteViewModel
    {
        public NoteDTO Note { get; set; }
        public NoteViewModel(int id)
        {
            Note = App.Notes.Where(n => n.Id == id).FirstOrDefault();
        }

        public NoteViewModel()
        {
            Note = new NoteDTO
            {
                Content = "",
                AddDate = DateTime.Now
            };
        }

        internal void AddNote()
        {
            App.Notes.Add(Note);
        }

        internal void EditNote()
        {
            App.Notes.Where(n => n.Id == Note.Id).FirstOrDefault().Content = Note.Content;
        }
    }
}
