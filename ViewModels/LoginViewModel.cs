using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using Tmds.DBus.Protocol;

namespace School_Project.ViewModels;

public class LoginViewModel: ViewModelBase
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Message { 
        get => _message; 
        set =>this.RaiseAndSetIfChanged(ref _message, value); }

    private string _message;
    public LoginViewModel()
    {
        LoginCommand = ReactiveCommand.CreateFromTask(TryLoginAsync);
    }

    public ICommand LoginCommand { get; }

    public async Task <bool> TryLoginAsync()
    {
        if (Login =="admin" && Password=="admin")
        {
            Message = "Access Granted";
            return true;
        }
        return false;
    } //contruction + commander +reactive
}
