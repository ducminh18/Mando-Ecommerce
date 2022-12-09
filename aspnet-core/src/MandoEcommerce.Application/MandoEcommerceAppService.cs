using System;
using System.Collections.Generic;
using System.Text;
using MandoEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace MandoEcommerce;

/* Inherit your application services from this class.
 */
public abstract class MandoEcommerceAppService : ApplicationService
{
    protected MandoEcommerceAppService()
    {
        LocalizationResource = typeof(MandoEcommerceResource);
    }
}
