using MailKit.Net.Smtp;
using MimeKit;
using MyWebsite.Models;

namespace MyWebsite.Services
{
    public class ContactService : IContactService
    {   
        
        public void SendEmail(Contact Contact)
        {
          var mimeMessage = new MimeMessage();
          mimeMessage.From.Add(new MailboxAddress(Contact.FromEmail));
          mimeMessage.To.Add(new MailboxAddress("bacior1988@gmail.com"));
          mimeMessage.Subject = Contact.Subject;
          mimeMessage.Body = new TextPart("plain")
          {
              Text = Contact.Text
          };

          using(var client = new SmtpClient())
          {
              client.Connect("smtp.gmail.com", 587, false);
              client.Authenticate("bacior1988@gmail.com", "batman88");
              client.Send(mimeMessage);
              client.Disconnect(true);
          }
        }
    }
}