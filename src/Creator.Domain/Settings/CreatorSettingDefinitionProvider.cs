using Volo.Abp.Settings;

namespace Creator.Settings;

public class CreatorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CreatorSettings.MySetting1));
    }
}
