﻿using Xamarin.Forms;

namespace XFCustomControls.ViewModels
{
    public class MasterViewModel
    {
        public Command NavigateCommand { get; set; }

        public MasterViewModel()
        {
            NavigateCommand = new Command(async (item) => {
                var viewName = (string)item;
                Page view;
                switch (viewName)
                {
                    case "ListViewExtView":
                        view = new Views.ListViewExtView();
                        break;
                    default:
                        view = new Page();
                        break;
                }
                await App.Current.MainPage.Navigation.PushAsync(view);
            });
        }
    }
}