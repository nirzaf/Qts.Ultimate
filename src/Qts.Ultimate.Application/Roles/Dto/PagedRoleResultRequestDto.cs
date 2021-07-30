using Abp.Application.Services.Dto;

namespace Qts.Ultimate.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

