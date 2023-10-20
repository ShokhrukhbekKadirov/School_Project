using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Tmds.DBus.Protocol;

namespace School_Project.ViewModels;

public class LoginViewModel: ViewModelBase
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Message { get; set; }
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
