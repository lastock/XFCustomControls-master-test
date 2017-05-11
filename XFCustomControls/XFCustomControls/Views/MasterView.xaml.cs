
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCustomControls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterView : ContentPage
    {
        public MasterView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.MasterViewModel();
        }
    }
}
