using System.Threading.Tasks;
using Creator.Localization;
using Creator.MultiTenancy;
using Creator.Permissions;

using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Creator.Web.Menus;

public class CreatorMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<CreatorResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                CreatorMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        //CHECK the PERMISSION
        if (await context.IsGrantedAsync(CreatorPermissions.JobInfos.Default))
        {
            context.Menu.AddItem(
            new ApplicationMenuItem(
                "JobSchedule",
                l["Menu:JobSchedule"],
                icon: "fa fa-book"
            ).AddItem(
                new ApplicationMenuItem(
                "JobInfos",
                l["Menu:JobInfos"],
                url: "/JobInfos"
                )
            )
            );
        }

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
