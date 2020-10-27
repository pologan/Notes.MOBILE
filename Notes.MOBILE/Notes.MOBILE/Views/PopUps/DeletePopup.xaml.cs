using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.MOBILE.Views.PopUps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public static readonly BindableProperty YesCommandProperty = BindableProperty.Create(nameof(YesCommand), typeof(ICommand), typeof(DeletePopup));
        public static readonly BindableProperty NoCommandProperty = BindableProperty.Create(nameof(NoCommand), typeof(ICommand), typeof(DeletePopup));

        public ICommand YesCommand
        {
            get => (ICommand)this.GetValue(YesCommandProperty);
            set => this.SetValue(YesCommandProperty, value);
        }
        public ICommand NoCommand
        {
            get => (ICommand)this.GetValue(NoCommandProperty);
            set => this.SetValue(NoCommandProperty, value);
        }
        public DeletePopup()
        {
            InitializeComponent();
        }
    }
}