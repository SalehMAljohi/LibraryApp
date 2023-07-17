using Abp.Application.Services;
using LibraryApp.MultiTenancy.Dto;

namespace LibraryApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

