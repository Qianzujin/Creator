using Creator.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Creator.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CreatorController : AbpControllerBase
{
    protected CreatorController()
    {
        LocalizationResource = typeof(CreatorResource);
    }
}
