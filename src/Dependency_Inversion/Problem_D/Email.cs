namespace Problem_D
{
    public class Email
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        

        public Email(string subject, string content, string address)
        {
            Subject = subject;
            Content = content;
            Address = address;
        }

        public void SendEmail()
        {
            Console.WriteLine($"Se ha enviado un correo a {Address} con el asunto: {Subject}.");
            Console.WriteLine($"Contenido: {Content}.");
        }
    }
}
