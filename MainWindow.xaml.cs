using System.Windows;

namespace UserManagementApp
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }

        private void OpenAddUserWindow(object sender, RoutedEventArgs e)
        {
            var addUserWindow = new AddUserWindow();
            addUserWindow.Closed += (s, args) => _viewModel.LoadUsers();
            addUserWindow.Show();
        }
    }
}