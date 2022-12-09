using MandoEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MandoEcommerce.Admin.Permissions;

public class MandoEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MandoEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MandoEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MandoEcommerceResource>(name);
    }
}
