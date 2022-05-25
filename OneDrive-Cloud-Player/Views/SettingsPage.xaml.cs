﻿using Microsoft.Extensions.DependencyInjection;
using OneDrive_Cloud_Player.ViewModels;
using Windows.UI.Xaml.Controls;

namespace OneDrive_Cloud_Player.Views
{
    public sealed partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            this.InitializeComponent();
            var container = App.Current.Container;
            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(SettingsPageViewModel));
        }
    }
}
