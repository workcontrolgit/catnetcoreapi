using catnetcoreapi.Application.DTOs.Email;
using System.Threading.Tasks;

namespace catnetcoreapi.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
