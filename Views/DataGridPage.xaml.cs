using ActionNowWinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using System;

namespace ActionNowWinUI.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class DataGridPage : Page
{
    public DataGridViewModel ViewModel
    {
        get;
    }

    public DataGridPage()
    {
        ViewModel = App.GetService<DataGridViewModel>();
        InitializeComponent();
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: Thêm logic để thêm dữ liệu mới
        // Ví dụ: Mở dialog để nhập dữ liệu mới
        ContentDialog addDialog = new ContentDialog
        {
            Title = "Thêm dữ liệu mới",
            PrimaryButtonText = "Lưu",
            CloseButtonText = "Hủy",
            DefaultButton = ContentDialogButton.Primary,
            XamlRoot = this.XamlRoot
        };

        // TODO: Thêm các control để nhập dữ liệu vào dialog
        addDialog.ShowAsync();
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        if (DataGrid.SelectedItem != null)
        {
            // TODO: Thêm logic để xóa dữ liệu đã chọn
            ContentDialog deleteDialog = new ContentDialog
            {
                Title = "Xác nhận xóa",
                Content = "Bạn có chắc chắn muốn xóa mục này?",
                PrimaryButtonText = "Xóa",
                CloseButtonText = "Hủy",
                DefaultButton = ContentDialogButton.Close,
                XamlRoot = this.XamlRoot
            };

            deleteDialog.PrimaryButtonClick += async (s, args) =>
            {
                // TODO: Thêm logic xóa dữ liệu ở đây
                // Ví dụ: ViewModel.DeleteItem(DataGrid.SelectedItem);
            };

            deleteDialog.ShowAsync();
        }
        else
        {
            ContentDialog noSelectionDialog = new ContentDialog
            {
                Title = "Thông báo",
                Content = "Vui lòng chọn mục cần xóa",
                CloseButtonText = "Đóng",
                DefaultButton = ContentDialogButton.Close,
                XamlRoot = this.XamlRoot
            };

            noSelectionDialog.ShowAsync();
        }
    }
}
