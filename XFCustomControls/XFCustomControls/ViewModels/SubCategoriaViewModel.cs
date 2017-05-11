using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFCustomControls.Models;
using XFCustomControls.Servicos;

namespace XFCustomControls.ViewModels
{
    class SubCategoriasViewModel : ViewModel
    {
        public ObservableCollection<SubCategoria> Items { get; }
        public Command ItemTappedCommand { get; set; }

        public SubCategoriasViewModel(int categoria)
        {
            this.Items = new ObservableCollection<SubCategoria>();
            this.AddItems(categoria);

            this.ItemTappedCommand = new Command<SubCategoria>(async item =>
            {
                await App.Current.MainPage.DisplayAlert("SubCategoria", item.NomeSubCategoria.ToString(), "Ok");
            });


        }

        private void AddItems(int categoria)
        {
            var subCategorias = new PopulaListaSubCategorias().Popula(categoria);
            foreach (var subCategoria in subCategorias)
            {
                this.Items.Add(subCategoria);
            }

        }

    }
}
