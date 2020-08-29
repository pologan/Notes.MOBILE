using Notes.MOBILE.Models.Enum;
using Notes.MOBILE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPage : ContentPage
    {
        private NoteViewModel _vm;

        public AddEditEnum AddEdit { get; set; }
        public AddEditPage(int id)
        {
            _vm = new NoteViewModel(id);
            BindingContext = _vm;

            InitializeComponent();

            AddEdit = AddEditEnum.Edit;
        }

        public AddEditPage()
        {
            _vm = new NoteViewModel();
            BindingContext = _vm;

            InitializeComponent();

            AddEdit = AddEditEnum.Add;
        }

        private async void CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private async void ApplyClicked(object sender, EventArgs e)
        {
            switch(AddEdit){
                case AddEditEnum.Add:
                    _vm.AddNote();
                    break;
                case AddEditEnum.Edit:
                    _vm.EditNote();
                    break;
            }
            await Navigation.PopAsync(true);
        }
    }
}