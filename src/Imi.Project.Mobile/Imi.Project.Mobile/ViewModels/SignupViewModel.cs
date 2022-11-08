using FreshMvvm;
using Imi.Project.Mobile.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class SignupViewModel : FreshBasePageModel
    {
        public SignupViewModel()
        {

        }
        public ICommand RedirectToLoginPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<LoginViewModel>(true);
            }
        );
    }
}
