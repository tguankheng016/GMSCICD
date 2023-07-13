using System.Threading.Tasks;
using Abp.Application.Services;
using GMS.Sessions.Dto;

namespace GMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
