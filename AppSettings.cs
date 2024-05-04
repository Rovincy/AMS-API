using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimsData.Service
{
    public static class AppSettings
    {
        public static IConfiguration Configuration { get; set; }

        public static string RxConnectionString { get; set; }

        public static string HimsConnectionString { get; set; }
    }
}
