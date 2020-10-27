using Notes.API.Models;
using Notes.MOBILE.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notes.MOBILE.Data
{
    public interface IRestService
    {
        Task<List<Note>> GetAllNotesAsync();
        Task AddNewNoteAsync(NoteCreateDto note);
        Task EditNoteAsync(int id, NoteUpdateDto newNote);
        Task DeleteNoteAsync(int id);
    }
}
