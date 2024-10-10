using System.Collections.ObjectModel;
using System.ComponentModel;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly DatabaseHelper _databaseHelper;
    private ObservableCollection<User> _users;

    public ObservableCollection<User> Users
    {
        get => _users;
        set
        {
            _users = value;
            OnPropertyChanged(nameof(Users));
        }
    }

    public MainViewModel()
    {
        _databaseHelper = new DatabaseHelper();
        LoadUsers();
    }

    public void LoadUsers()
    {
        Users = new ObservableCollection<User>(_databaseHelper.GetAllUsers());
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}