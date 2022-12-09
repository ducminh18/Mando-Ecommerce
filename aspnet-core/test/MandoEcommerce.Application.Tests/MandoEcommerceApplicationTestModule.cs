using Volo.Abp.Modularity;

namespace MandoEcommerce;

[DependsOn(
    typeof(MandoEcommerceApplicationModule),
    typeof(MandoEcommerceDomainTestModule)
    )]
public class MandoEcommerceApplicationTestModule : AbpModule
{

}
