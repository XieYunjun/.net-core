using XYJ.HelloAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace XYJ.HelloAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HelloAbpEntityFrameworkCoreModule),
    typeof(HelloAbpApplicationContractsModule)
    )]
public class HelloAbpDbMigratorModule : AbpModule
{

}
