using Notes.API.Models;
using Notes.MOBILE.Dtos;
using PropertyChanged;
using System;
using System.Linq;

namespace Notes.MOBILE.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class NoteViewModel
    {
        public Note Note { get; set; }
        public string Content { get; set; }
        public NoteViewModel(int id)
        {
            Note = App.Notes.Where(n => n.Id == id).FirstOrDefault();

            Content = Note.Content;
        }

        public NoteViewModel()
        {
            Note = new Note
            {
                Content = "",
                AddDate = DateTime.Now
            };
        }

        internal void AddNote()
        {
            Note.Content = Content;
            App.NotesManager.CreateNoteAsync(new NoteCreateDto
            {
                Content = Note.Content,
                AddDate = Note.AddDate
            });
        }

        internal void EditNote()
        {
            Note.Content = Content;
            App.NotesManager.UpdateNoteAsync(Note.Id, new NoteUpdateDto { AddDate = Note.AddDate, Content = Note.Content });
        }
    }
}
