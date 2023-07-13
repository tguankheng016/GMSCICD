using System.Threading.Tasks;
using Abp.Application.Services;
using GMS.Authorization.Accounts.Dto;

namespace GMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
