using System.Net.Mail;
using MyWebsite.Models;

namespace MyWebsite.Services
{
    public class ContactService : IContactService
    {   
        
        public ContactService()
        {

        }

        public void SendEmail(Contact Contact)
        {
            MailMessage mail = new MailMessage("bacior1988@gmail.com", Contact.Email, Contact.Subject, Contact.Text);
            SmtpClient client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };
            
            client.Send(mail);
        }
    }
}