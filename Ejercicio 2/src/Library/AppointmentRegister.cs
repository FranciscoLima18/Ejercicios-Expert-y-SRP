using System;
using System.Text;

namespace Library
{
    public class AppointmentRegister
    {
        public static string RegisterAppointment(string name, string phone, string email, DateTime date, string address, string doctor)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Appointment created successfully");
            mensaje.Append("\n");
            mensaje.Append("Name: " + name);
            mensaje.Append("\n");
            mensaje.Append("Telephone: " + phone);
            mensaje.Append("\n");
            mensaje.Append("Email: " + email);
            mensaje.Append("\n");
            mensaje.Append("Date: " + date);
            mensaje.Append("\n");
            mensaje.Append("Adress: " + address);
            mensaje.Append("\n");
            mensaje.Append("Doctor: " + doctor);
            return mensaje.ToString();
        }
    }
}
