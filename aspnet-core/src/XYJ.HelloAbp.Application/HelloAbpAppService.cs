using System;
using System.Collections.Generic;
using System.Text;
using XYJ.HelloAbp.Localization;
using Volo.Abp.Application.Services;

namespace XYJ.HelloAbp;

/* Inherit your application services from this class.
 */
public abstract class HelloAbpAppService : ApplicationService
{
    protected HelloAbpAppService()
    {
        LocalizationResource = typeof(HelloAbpResource);
    }
}
