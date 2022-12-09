using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MandoEcommerce;

[Dependency(ReplaceServices = true)]
public class MandoEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MandoEcommerce";
}
