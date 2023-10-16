using ReactiveUI.Fody.Helpers;

namespace School_Project.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive] public LoginViewModel LoginViewModel { get; set; }
        public MainWindowViewModel()
        {
            LoginViewModel = new LoginViewModel();
        }
    }
}