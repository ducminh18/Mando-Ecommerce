using System.Threading.Tasks;

namespace MandoEcommerce.Data;

public interface IMandoEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
