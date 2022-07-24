using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Creator.Web;

[Dependency(ReplaceServices = true)]
public class CreatorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Creator";
}
