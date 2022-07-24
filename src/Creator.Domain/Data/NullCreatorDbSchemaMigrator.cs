using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Creator.Data;

/* This is used if database provider does't define
 * ICreatorDbSchemaMigrator implementation.
 */
public class NullCreatorDbSchemaMigrator : ICreatorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
