using System;
using System.Text;

namespace Library
{


    public class AppointmentValidator
    {
        public static bool Validator(string name, string phone, string email, DateTime date, string address, string doctor)
        {
            if (name != null && phone != null && email != null && address != null && doctor != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}