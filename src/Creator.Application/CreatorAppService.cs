using System;
using System.Collections.Generic;
using System.Text;
using Creator.Localization;
using Volo.Abp.Application.Services;

namespace Creator;

/* Inherit your application services from this class.
 */
public abstract class CreatorAppService : ApplicationService
{
    protected CreatorAppService()
    {
        LocalizationResource = typeof(CreatorResource);
    }
}
