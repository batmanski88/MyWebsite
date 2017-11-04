
using System.Net;
using System.Net.Mail;
using MyWebsite.Models;

namespace MyWebsite.Services
{
    public class ContactService : IContactService
    {   
        
        public void SendEmail(Contact Contact)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("bacior1988@gmail.com", "batman88")
            };
            

            MailMessage message = new MailMessage();
            message.From = new MailAddress(Contact.FromEmail);
            message.To.Add("bacior1988@gmail.com");
            message.Subject = Contact.Subject;
            message.Body = Contact.Text;

            client.Send(message);
        }
    }
}