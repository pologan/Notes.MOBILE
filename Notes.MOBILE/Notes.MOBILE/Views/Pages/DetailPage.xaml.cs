using Notes.MOBILE.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private NoteViewModel _vm;
        public DetailPage(int id)
        {
            _vm = new NoteViewModel(id);
            BindingContext = _vm;
            
            InitializeComponent();
        }

        private async void BackClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}