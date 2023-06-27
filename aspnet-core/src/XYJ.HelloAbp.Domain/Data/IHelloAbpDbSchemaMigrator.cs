using System.Threading.Tasks;

namespace XYJ.HelloAbp.Data;

public interface IHelloAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
