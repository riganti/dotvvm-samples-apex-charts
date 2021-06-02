using DotVVM.Framework.Configuration;
using DotVVM.Framework.ResourceManagement;
using DotVVM.Framework.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace ApexChartsSample
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {

            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureStylesheets(config, applicationPath);
            ConfigureScripts(config, applicationPath);
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/Default.dothtml");
            config.RouteTable.AutoDiscoverRoutes(new DefaultRouteStrategy(config));
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
        }

        private void ConfigureScripts(DotvvmConfiguration config, string applicationPath)
        {
            config.Resources.Register("apex-charts-js", new ScriptResource()
            {
                Location = new UrlResourceLocation("~/ApexCharts/apexcharts.min.js")
            });
        }

        private void ConfigureStylesheets(DotvvmConfiguration config, string applicationPath)
        {
            config.Resources.Register("style-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/Resources/style.css")
            });
            config.Resources.Register("apex-charts-css", new StylesheetResource()
            {
                Location = new UrlResourceLocation("~/ApexCharts/apexcharts.css")
            });
        }

        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("temp");
        }
    }
}
