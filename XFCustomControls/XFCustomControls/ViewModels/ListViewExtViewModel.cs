using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFCustomControls.Models;
using XFCustomControls.Servicos;

namespace XFCustomControls.ViewModels
{
    public class ListViewExtViewModel : ViewModel
    {
        public ObservableCollection<Categoria> Items { get; set; }
        public Command ItemTappedCommand { get; set; }

        public ListViewExtViewModel()
        {
            this.Items = new ObservableCollection<Categoria>();
            this.AddItems();

            this.ItemTappedCommand = new Command<Categoria>(async item =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new Views.SubCategorias(item.IdCategoria));
            });

        }

        private void AddItems()
        {
            var categorias = new PopulaListaCategorias().Popula();
            foreach (var categoria in categorias)
            {
                this.Items.Add(categoria);
            }

        }
    }
}