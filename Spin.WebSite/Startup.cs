using Microsoft.Extensions.Configuration;
using Spin.Base.Helper.Base;
using Spin.Diagnostics.API.DiagnosticLog.Providers.Console;
using Spin.Diagnostics.Entity.DiagnosticLog;

namespace Spin.WebSite
{
    public class Startup : SpinStartup
    {
        #region Startup

        public Startup(IConfiguration configuration)
            : base(configuration)
        {
            this.AddProviderDiagnosticLog(new ConsoleProviderDiagnostics(TypeMessage.Error));
        }

        #endregion Startup
    }
}