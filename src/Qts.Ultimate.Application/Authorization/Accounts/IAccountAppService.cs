using System.Threading.Tasks;
using Abp.Application.Services;
using Qts.Ultimate.Authorization.Accounts.Dto;

namespace Qts.Ultimate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
