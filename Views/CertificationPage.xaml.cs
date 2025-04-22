using ActionNowWinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ActionNowWinUI.Views;

public sealed partial class CertificationPage : Page
{
    public CertificationViewModel ViewModel
    {
        get;
    }

    public CertificationPage()
    {
        ViewModel = App.GetService<CertificationViewModel>();
        InitializeComponent();
    }
}
