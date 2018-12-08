using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LP.Services.Core.Constants;

namespace LP.Services.Poco
{
    public class LandingPage
    {
        public int Id { get; set; } 
        public ThemeTypes Theme { get; set; }
        public string HostingSite { get; set; }
        public string LpUrl { get; set; }
        public string LeftLogoUrl { get; set; }
        public string MiddleLogoUrl { get; set; }
        public string RightLogoUrl { get; set; }
        public string BrandName { get; set; }
    }
}
