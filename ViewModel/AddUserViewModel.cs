using System;
using System.ComponentModel;
using System.Windows.Input;

public class AddUserViewModel : INotifyPropertyChanged
{
    private readonly DatabaseHelper _databaseHelper;
    private string _username;
    private string _email;

    public string Username
    {
        get => _username;
        set
        {
            _username = value;
            OnPropertyChanged(nameof(Username));
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    public ICommand AddUserCommand { get; }

    public AddUserViewModel()
    {
        _databaseHelper = new DatabaseHelper();
        AddUserCommand = new RelayCommand(AddUser, CanAddUser);
    }

    private bool CanAddUser()
    {
        return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Email);
    }

    private void AddUser()
    {
        var user = new User { Username = Username, Email = Email };
        _databaseHelper.AddUser(user);
        Username = string.Empty;
        Email = string.Empty;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class RelayCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public RelayCommand(Action execute, Func<bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public bool CanExecute(object parameter) => _canExecute == null || _canExecute();

    public void Execute(object parameter) => _execute();
}