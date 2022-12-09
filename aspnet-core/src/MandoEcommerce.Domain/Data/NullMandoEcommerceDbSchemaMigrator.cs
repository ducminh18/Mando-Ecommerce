using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MandoEcommerce.Data;

/* This is used if database provider does't define
 * IMandoEcommerceDbSchemaMigrator implementation.
 */
public class NullMandoEcommerceDbSchemaMigrator : IMandoEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
