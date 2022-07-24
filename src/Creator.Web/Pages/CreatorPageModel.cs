using Creator.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Creator.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CreatorPageModel : AbpPageModel
{
    protected CreatorPageModel()
    {
        LocalizationResourceType = typeof(CreatorResource);
    }
}
