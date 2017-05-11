
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCustomControls.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewExtView : ContentPage
    {
        public ListViewExtView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExtViewModel();
        }
    }
}
