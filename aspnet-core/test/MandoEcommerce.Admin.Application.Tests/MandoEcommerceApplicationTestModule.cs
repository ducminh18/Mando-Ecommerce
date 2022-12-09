using Volo.Abp.Modularity;

namespace MandoEcommerce.Admin;

[DependsOn(
    typeof(MandoEcommerceAdminApplicationModule),
    typeof(MandoEcommerceDomainTestModule)
    )]
public class MandoEcommerceApplicationTestModule : AbpModule
{

}
