using XYJ.HelloAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XYJ.HelloAbp;

[DependsOn(
    typeof(HelloAbpEntityFrameworkCoreTestModule)
    )]
public class HelloAbpDomainTestModule : AbpModule
{

}
