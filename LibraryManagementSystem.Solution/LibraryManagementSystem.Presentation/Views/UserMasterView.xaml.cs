using LibraryManagementSystem.Presentation.ViewModels;
using System.Windows;

namespace LibraryManagementSystem.Presentation.Views
{
    public partial class UserMasterView : Window
    {
        public UserMasterView(UserMasterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
