using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string phone, string email, DateTime date, string address, string doctor)
        {
            if (AppointmentValidator.Validator(name, phone, email, date, address, doctor))
            {
                return AppointmentRegister.RegisterAppointment(name, phone, email, date, address, doctor);
            }
            else
            {
                return "Appointment Error";
            }
        }

    }
}