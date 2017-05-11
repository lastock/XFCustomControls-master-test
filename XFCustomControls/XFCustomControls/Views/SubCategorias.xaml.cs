using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFCustomControls.ViewModels;

namespace XFCustomControls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubCategorias : ContentPage
    {
        public SubCategorias(int Categoria)
        {
            InitializeComponent();
            BindingContext = new SubCategoriasViewModel(Categoria);
        }

    }



}
