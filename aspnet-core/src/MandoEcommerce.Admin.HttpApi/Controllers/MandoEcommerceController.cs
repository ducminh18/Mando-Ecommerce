﻿using MandoEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MandoEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MandoEcommerceController : AbpControllerBase
{
    protected MandoEcommerceController()
    {
        LocalizationResource = typeof(MandoEcommerceResource);
    }
}
