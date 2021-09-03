using System.Threading.Tasks;

namespace ShopApp.WebUI
{
    public interface IEmailSSender
    {
        Task SendEmailAsync(string email, string v1, string v2);
    }
}