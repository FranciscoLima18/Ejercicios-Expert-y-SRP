using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medical Appointment System");

            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter patient phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter patient email: ");
            string email = Console.ReadLine();

            Console.Write("Enter appointment date (yyyy-MM-dd HH:mm): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.Write("Enter patient address: ");
                string address = Console.ReadLine();

                Console.Write("Enter doctor's name: ");
                string doctor = Console.ReadLine();

                string result = Library.AppointmentService.CreateAppointment(name, phone, email, date, address, doctor);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd HH:mm.");
            }
        }
    }
}

/*
Principio SRP: La clase Appointment no cumple con el, ya que tiene varias responsabilidades
para cumplir, entre ellas: validar los datos y crear un mensaje sobra la consulta.
Patron EXPERT: lo ideal en esta clase es dividirla en dos, separando la responsabilidad de
validar los datos en una propia clase separada.
*/