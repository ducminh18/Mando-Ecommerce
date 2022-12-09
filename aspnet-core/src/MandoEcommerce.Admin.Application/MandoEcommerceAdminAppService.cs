using System;
using System.Collections.Generic;
using System.Text;
using MandoEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace MandoEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class MandoEcommerceAdminAppService : ApplicationService
{
    protected MandoEcommerceAdminAppService()
    {
        LocalizationResource = typeof(MandoEcommerceResource);
    }
}
