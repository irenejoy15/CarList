﻿using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui
{
    public partial class MainPage: ContentPage
    {
      
        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;

            //Preferences.Set("saveDetails", true);
            //var detailsSaved = Preferences.Get("saveDetails", false);
        }
    }

}
