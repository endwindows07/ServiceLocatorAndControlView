using System;
namespace TestConnectionCheck.Service
{
    public interface IAert
    {
        void SendAlert(string message);
        //bool _alert { get; set; }
        bool Alert { get; set; }
        //string _message { get; set; }
        string Message { get; set; }
    }
}
