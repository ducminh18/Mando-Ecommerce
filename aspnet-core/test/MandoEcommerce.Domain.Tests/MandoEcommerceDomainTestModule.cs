using MandoEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MandoEcommerce;

[DependsOn(
    typeof(MandoEcommerceEntityFrameworkCoreTestModule)
    )]
public class MandoEcommerceDomainTestModule : AbpModule
{

}
