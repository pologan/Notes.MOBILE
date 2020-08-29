using Notes.MOBILE.Models.DTOs;
using Notes.MOBILE.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}