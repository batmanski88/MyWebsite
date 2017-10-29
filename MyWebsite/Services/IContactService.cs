using MyWebsite.Models;

namespace MyWebsite.Services
{
    public interface IContactService
    {
        void SendEmail(Contact Contact);
    }
}