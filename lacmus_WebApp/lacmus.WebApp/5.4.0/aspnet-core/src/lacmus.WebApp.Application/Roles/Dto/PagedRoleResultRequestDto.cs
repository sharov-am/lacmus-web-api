using Abp.Application.Services.Dto;

namespace lacmus.WebApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

