using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_D
{
    public class NotifyEmployee
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string Content { get; set; }

        private Email email;
        private SMS sms;

        public NotifyEmployee(string address, string subject, string content, string phoneNumber)
        {
            Address = address;
            Subject = subject;
            Content = content;
            PhoneNumber = phoneNumber;

            email = new Email(subject, content, address);
            sms = new SMS(phoneNumber, content);
        }

        public void Notify()
        {
            email.SendEmail();
            sms.SendSMS();
        }
    }
}
