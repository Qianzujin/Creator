using System.Threading.Tasks;

namespace Creator.Data;

public interface ICreatorDbSchemaMigrator
{
    Task MigrateAsync();
}
