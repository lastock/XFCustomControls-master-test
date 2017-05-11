
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCustomControls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerExtView : ContentPage
    {
        public PickerExtView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.PickerViewModel();
        }
    }
}
