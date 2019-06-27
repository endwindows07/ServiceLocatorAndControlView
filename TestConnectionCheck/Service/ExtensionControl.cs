using System;
using System.Linq;
using TestConnectionCheck.Service;

namespace TestConnectionCheck
{
    public static class ExtensionControl
    {

        public static string GetBaseInerException(this Exception ex)
        {
            string[] error = ex.StackTrace.Split('/');

            while (ex != null && ex.InnerException != null)
            {
                if (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
            }
            Alert(ex.Message);
            return $"{ex.Message}::{error[error.Count() - 1]}";
            //return new Exception();
        }

        public static void Alert(this string message)
        {
            var alert = App.alertManage;
            alert.SendAlert(message);
        }



        public static Exception GetErrorExceptoin(this Exception exception)
        {

            if (exception.InnerException != null)
            {
                return exception.InnerException.GetErrorExceptoin();
            }
            return exception;
        }
    }
}
