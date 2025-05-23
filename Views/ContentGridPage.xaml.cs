﻿using ActionNowWinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ActionNowWinUI.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
