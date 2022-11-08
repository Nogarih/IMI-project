using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class LoginViewModel : FreshBasePageModel
    {
        public LoginViewModel()
        {

        }
        public ICommand LoginCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<MoviesViewModel>(true);
            }
        );

        public ICommand RedirectToSignupPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<SignupViewModel>(true);
            }
        );
    }
}