using System;
using System.ComponentModel;
using TestConnectionCheck.Service;
using TestConnectionCheck.ViewModel;
using Xamarin.Forms;

namespace TestConnectionCheck
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            //this.b = "Main Page";
            
            //this.BindingContext = App.alertManage;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //vm.SendAlert("vm call");
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            try
            {
                string error = "";
                if (error.Substring(9) == "")
                {

                }
            }
            catch (System.Exception ex)
            {
                new Exception("Input Is Valid").Message.Alert();
            }
        }
    }
}
