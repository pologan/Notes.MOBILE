using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.MOBILE.Models.DTOs
{
    public class NoteDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime AddDate { get; set; }
    }
}
