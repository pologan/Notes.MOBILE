using Notes.API.Models;
using Notes.MOBILE.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Notes.MOBILE.Data
{
    public class NotesManager
    {
        private IRestService _restService;

        public NotesManager(IRestService service)
        {
            _restService = service;
        }

        public Task<List<Note>> GetAllNotesAsync()
        {
            return _restService.GetAllNotesAsync();
        }

        public Task CreateNoteAsync(NoteCreateDto note)
        {
            return _restService.AddNewNoteAsync(note);
        }

        public Task UpdateNoteAsync(int id, NoteUpdateDto note)
        {
            return _restService.EditNoteAsync(id, note);
        }

        public Task DeleteNoteAsync(Note note)
        {
            return _restService.DeleteNoteAsync(note.Id);
        }
    }
}
