using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Test2
{
    public class Mail
    {
        static void Main()
        {
            List<string> emails = new List<string>();
            Console.Write("Escribe un email: ");
            string email = Console.ReadLine();

            while (email.ToLower() != "quit")
            {
                if (IsValidEmail(email))
                {
                    if (emails.Contains(email))
                    {
                        Console.WriteLine("Ya se ha validado el correo electrónico.");
                    }
                    else
                    {
                        emails.Add(email);
                        Console.WriteLine("El email es válido y se ha añadido a la lista.");
                    }
                }
                else
                {
                    Console.WriteLine("El email no es válido");
                }
                Console.Write("Escribe un email: ");
                email = Console.ReadLine();
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
