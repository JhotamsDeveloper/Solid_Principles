using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_D
{
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public SMS(string phoneNumber, string message)
        {
            PhoneNumber = phoneNumber;
            Message = message;
        }

        public void SendSMS()
        {
            Console.WriteLine($"Se ha enviado un SMS al número: {PhoneNumber}.");
            Console.WriteLine($"El message es: {Message}.");
        }
    }
}
