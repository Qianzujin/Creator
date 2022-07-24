using Creator.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Creator.Permissions;

public class CreatorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CreatorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CreatorPermissions.MyPermission1, L("Permission:MyPermission1"));

        var booksPermission = myGroup.AddPermission(CreatorPermissions.JobInfos.Default, L("Permission:JobInfos"));
        booksPermission.AddChild(CreatorPermissions.JobInfos.Create, L("Permission:JobInfos.Create"));
        booksPermission.AddChild(CreatorPermissions.JobInfos.Edit, L("Permission:JobInfos.Edit"));
        booksPermission.AddChild(CreatorPermissions.JobInfos.Delete, L("Permission:JobInfos.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CreatorResource>(name);
    }
}
