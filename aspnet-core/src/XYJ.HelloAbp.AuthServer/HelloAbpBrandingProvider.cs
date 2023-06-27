using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XYJ.HelloAbp;

[Dependency(ReplaceServices = true)]
public class HelloAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HelloAbp";
}
