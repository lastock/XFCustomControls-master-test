
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFCustomControls.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderExtView : ContentPage
    {
        public SliderExtView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.SliderExtViewModel();
        }
    }
}
