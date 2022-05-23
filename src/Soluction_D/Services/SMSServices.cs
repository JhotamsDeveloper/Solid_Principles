using Soluction_D.Interfaces;

namespace Soluction_D.Services
{
    public class SMSServices : INotify
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public SMSServices(string phoneNumber, string message)
        {
            PhoneNumber = phoneNumber;
            Message = message;
        }
        
        public void Notify()
        {
            Console.WriteLine($"Se ha enviado un SMS al número: {PhoneNumber}.");
            Console.WriteLine($"El message es: {Message}.");
        }
    }
}
