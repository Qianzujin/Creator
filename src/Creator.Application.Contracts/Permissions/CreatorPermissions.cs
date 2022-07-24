namespace Creator.Permissions;

public static class CreatorPermissions
{
    public const string GroupName = "Creator";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class JobInfos
    {
        public const string Default = GroupName + ".jobInfo";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
