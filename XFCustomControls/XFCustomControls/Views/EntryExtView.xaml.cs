
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCustomControls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryExtView : ContentPage
    {
        public EntryExtView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.EntryExtViewModel();
        }
    }
}
