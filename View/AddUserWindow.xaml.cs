using System.Windows;

namespace UserManagementApp
{
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
            DataContext = new AddUserViewModel();
        }
    }
}