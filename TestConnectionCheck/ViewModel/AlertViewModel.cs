using System;
using System.ComponentModel;
using TestConnectionCheck.Service;
using Xamarin.Forms;

namespace TestConnectionCheck.ViewModel
{
    public class AlertViewModel : INotifyPropertyChanged, IAert
    {
        public AlertViewModel()
        {
            MessagingCenter.Subscribe<object>(this, "ItemDestroy", async (it) => {
                Alert = false;
            });
        }



        EventHandler SlideIn;
        EventHandler SlideOut;

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _alert { get; set; }
        public bool Alert
        {
            get => _alert;
            set
            {
                _alert = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Alert"));
            }
        }

        private string _message { get; set; }
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Message"));
            }
        }

        public void SendAlert(string message)
        {
            Alert = true;
            Message = message;
            MessagingCenter.Send<object>(this, "SlideIn");

            Device.StartTimer(TimeSpan.FromSeconds(6), () =>
            {
                MessagingCenter.Send<object>(this, "SlideOut");
                Console.WriteLine("keep out");
                OnCountDownAlert();
                return false;
            });

            Console.WriteLine("...1");
        }

        private void OnCountDownAlert()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                Console.WriteLine("destroy item");
                Alert = false;
                return false;
            });

            Console.WriteLine("...1");
        }
    }
}
