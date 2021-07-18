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
    public partial class XF_SignUpPage : ContentPage
    {
        SignUpVM signUpVM;
        
        public XF_SignUpPage()
        {
            InitializeComponent();
            signUpVM = new SignUpVM();
            //set binding    
            BindingContext = signUpVM;
            passwordentery.IsPassword = true;
            cfmpasswordentery.IsPassword = true;
        }
        
        private void btn_Google_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_Android52_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_Vis_Clicked(object sender, EventArgs e)
        {
            if(passwordentery.IsPassword == true)
            {
                btn_Vis.ImageSource = "Sichtbar.png";
               
                passwordentery.IsPassword = false;
            }
            else
            {
                btn_Vis.ImageSource = "UnSichtbar.png";
              
                passwordentery.IsPassword = true;
            }
           
        }

        private void btn_Email_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_ReVis_Clicked(object sender, EventArgs e)
        {
            if (cfmpasswordentery.IsPassword == true)
            {
                btn_ReVis.ImageSource = "Sichtbar.png";

                cfmpasswordentery.IsPassword = false;
            }
            else
            {
                btn_ReVis.ImageSource = "UnSichtbar.png";

                cfmpasswordentery.IsPassword = true;
            }
        }

        private void btn_Username_Clicked(object sender, EventArgs e)
        {

        }
    }
}