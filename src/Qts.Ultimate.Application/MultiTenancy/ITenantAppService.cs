using Abp.Application.Services;
using Qts.Ultimate.MultiTenancy.Dto;

namespace Qts.Ultimate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

