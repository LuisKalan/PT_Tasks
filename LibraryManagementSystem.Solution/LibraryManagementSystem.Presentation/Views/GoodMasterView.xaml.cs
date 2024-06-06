using LibraryManagementSystem.Presentation.ViewModels;
using System.Windows;

namespace LibraryManagementSystem.Presentation.Views
{
    /// <summary>
    /// Lógica de interacción para GoodMasterView.xaml
    /// </summary>
    public partial class GoodMasterView : Window
    {
        public GoodMasterView(GoodMasterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
