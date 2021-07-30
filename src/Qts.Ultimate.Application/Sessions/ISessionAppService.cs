using System.Threading.Tasks;
using Abp.Application.Services;
using Qts.Ultimate.Sessions.Dto;

namespace Qts.Ultimate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
