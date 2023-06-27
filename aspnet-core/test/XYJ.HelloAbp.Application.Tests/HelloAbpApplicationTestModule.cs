using Volo.Abp.Modularity;

namespace XYJ.HelloAbp;

[DependsOn(
    typeof(HelloAbpApplicationModule),
    typeof(HelloAbpDomainTestModule)
    )]
public class HelloAbpApplicationTestModule : AbpModule
{

}
