using ActionNowWinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ActionNowWinUI.Views;

public sealed partial class AppealPage : Page
{
    public AppealViewModel ViewModel
    {
        get;
    }

    public AppealPage()
    {
        ViewModel = App.GetService<AppealViewModel>();
        InitializeComponent();
    }
}
