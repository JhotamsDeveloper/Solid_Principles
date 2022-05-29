using Soluction_D.Interfaces;

namespace Soluction_D.Services
{
    public class EmailServices : INotify
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public EmailServices(string address, string subject, string content)
        {
            Address = address;
            Subject = subject;
            Content = content;
        }
 
        public void Notify()
        {
            Console.WriteLine($"Se ha enviado un correo a {Address} con el asunto: {Subject}.");
            Console.WriteLine($"Contenido: {Content}.");
        }
    }
}
