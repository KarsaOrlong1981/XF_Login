using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.ViewModels;

namespace XF_Login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        WelcomeVM welcomeVM;
        public WelcomePage(string email)
        {
            InitializeComponent();
            welcomeVM = new WelcomeVM(email);
            BindingContext = welcomeVM;
        }
    }
}