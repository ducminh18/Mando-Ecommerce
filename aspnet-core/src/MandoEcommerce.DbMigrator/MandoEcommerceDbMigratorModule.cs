using MandoEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MandoEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MandoEcommerceEntityFrameworkCoreModule),
    typeof(MandoEcommerceApplicationContractsModule)
    )]
public class MandoEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
