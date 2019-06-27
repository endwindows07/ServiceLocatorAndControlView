using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestConnectionCheck
{
    public partial class Alert : Grid
    {
        public Alert()
        {


            InitializeComponent();
            this.BindingContext = App.alertManage;
            this.TranslateTo(0, 1500);

            //var alert = App.alertManage;
            MessagingCenter.Subscribe<object>(this, "SlideIn", async (it)=> {
                this.BackgroundColor = Color.FromHex("#B3F05250");
                await this.TranslateTo(0 , -250 , 0 );
                await this.TranslateTo(0, 0, 750);
                this.BackgroundColor = Color.FromHex("#F05250");
            });

            MessagingCenter.Subscribe<object>(this, "SlideOut", async (it) => {
                await this.TranslateTo(0, 0, 0);
                await this.TranslateTo(0, -250, 750);
                this.BackgroundColor = Color.FromHex("#B3F05250");

            });
        }

        void close(object sender, System.EventArgs e)
        {
            MessagingCenter.Send<object>(this, "ItemDestroy");
        }
    }
}
