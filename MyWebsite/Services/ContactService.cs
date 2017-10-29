using System.Net;
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
           SmtpClient client = new SmtpClient("smtp.gmail.com");
           client.UseDefaultCredentials = false;
           client.Credentials = new NetworkCredential("bacior1988@gmail.com" , "batman88");

           MailMessage mail = new MailMessage();
           mail.From = new MailAddress(Contact.Email);
           mail.To.Add("bacior1988@gmail.com");
           mail.Subject = Contact.Subject;
           mail.Body = Contact.Text;

           client.Send(mail);
        }
    }
}