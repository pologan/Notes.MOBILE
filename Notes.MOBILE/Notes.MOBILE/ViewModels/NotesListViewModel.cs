using Notes.MOBILE.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Notes.MOBILE.ViewModels
{
    public class NotesListViewModel
    {
        public ObservableCollection<NoteViewModel> Notes { get; set; }
        public NotesListViewModel()
        {
            App.Notes = new ObservableCollection<NoteDTO>
            {
                new NoteDTO
                {
                    Id = 0,
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec congue tempor enim, vitae dapibus odio rutrum " +
                    "vitae. Sed id purus id ante fringilla porttitor quis vel enim. Nulla facilisi. In ipsum turpis, aliquam eu velit at, venenatis " +
                    "luctus orci. Donec finibus sit amet odio vel ultricies. Vivamus sed sollicitudin arcu. Ut felis tellus, finibus id mattis non, volutpat" +
                    " et magna. Morbi molestie varius aliquet. Nullam sed efficitur justo, nec suscipit risus. Pellentesque maximus, ligula at sollicitudin malesuada," +
                    " mi nibh finibus ipsum, vel volutpat velit tortor vel leo. Curabitur quis tempus leo, in feugiat diam. Aliquam sed tortor nisi.",
                    AddDate = DateTime.Now
                },
                new NoteDTO
                {
                    Id = 1,
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec congue tempor enim, vitae dapibus odio rutrum " +
                    "vitae. Sed id purus id ante fringilla porttitor quis vel enim. Nulla facilisi. In ipsum turpis, aliquam eu velit at, venenatis " +
                    "luctus orci. Donec finibus sit amet odio vel ultricies. Vivamus sed sollicitudin arcu. Ut felis tellus, finibus id mattis non, volutpat" +
                    " et magna. Morbi molestie varius aliquet. Nullam sed efficitur justo, nec suscipit risus. Pellentesque maximus, ligula at sollicitudin malesuada," +
                    " mi nibh finibus ipsum, vel volutpat velit tortor vel leo. Curabitur quis tempus leo, in feugiat diam. Aliquam sed tortor nisi.",
                    AddDate = DateTime.Now
                },
                new NoteDTO
                {
                    Id = 2,
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec congue tempor enim, vitae dapibus odio rutrum " +
                    "vitae. Sed id purus id ante fringilla porttitor quis vel enim. Nulla facilisi. In ipsum turpis, aliquam eu velit at, venenatis " +
                    "luctus orci. Donec finibus sit amet odio vel ultricies. Vivamus sed sollicitudin arcu. Ut felis tellus, finibus id mattis non, volutpat" +
                    " et magna. Morbi molestie varius aliquet. Nullam sed efficitur justo, nec suscipit risus. Pellentesque maximus, ligula at sollicitudin malesuada," +
                    " mi nibh finibus ipsum, vel volutpat velit tortor vel leo. Curabitur quis tempus leo, in feugiat diam. Aliquam sed tortor nisi.",
                    AddDate = DateTime.Now
                },
            };
        }
    }
}
