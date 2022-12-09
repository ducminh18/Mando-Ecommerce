using Volo.Abp.Settings;

namespace MandoEcommerce.Settings;

public class MandoEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MandoEcommerceSettings.MySetting1));
    }
}
