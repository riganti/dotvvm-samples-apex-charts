using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace ApexChartsSample.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public string Title { get; set; }

        public DefaultViewModel()
        {
            Title = "DotVVM ♥ Apex Charts";
        }

        public int[] AreaData1 { get; set; } = { 31, 40, 28, 51, 42, 109, 100 };
        public int[] AreaData2 { get; set; } = { 11, 32, 45, 32, 34, 52, 41 };

        public string[] Teams { get; set; } = { "Team A", "Team B", "Team C", "Team D", "Team E" };
        public int[] TeamsData { get; set; } = { 11, 32, 45, 32, 34, 52, 41 };
        public string[] Countries { get; set; } = { "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan",
            "United States", "China", "Germany"};
        public int[] CountriesData { get; set; } = { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
    }
}
