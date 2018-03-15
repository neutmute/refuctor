using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using Refuctor.Objects;
using Refuctor.Xml;

namespace Refuctor
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var looper = new FileLooper();
            var rdgParser = new RdgParser();

            //looper.RootPath = @"D:\Downloads\test\Phoenix.QuoteFacade.Core\Domain\Origination\Schema";
            //looper.IsTestMode = false;

            //looper.Terms.Add(new Term { Target = "Metric Reading", ReplaceWith = "Metric Value" });
            //looper.Terms.Add(new Term { Target = "Mib Reading", ReplaceWith = "Mib Value" });

            //looper.Terms.Add(new Term { Target = "MetricReading", ReplaceWith = "MetricValue" });
            //looper.Terms.Add(new Term { Target = "DeviceReading", ReplaceWith = "DeviceValue" });
            //looper.Terms.Add(new Term { Target = "MibReading", ReplaceWith = "MibValue" });

            //looper.Terms.Add(new Term { Target = "Mib Scan", ReplaceWith = "Mib Reading" });
            //looper.Terms.Add(new Term { Target = "Metric Scan", ReplaceWith = "Metric Reading" });
            //looper.Terms.Add(new Term {Target = "MetricScan", ReplaceWith = "MetricReading"});
            //looper.Terms.Add(new Term { Target = "MibScan", ReplaceWith = "MibReading" });


            rdgParser.Go();

            Console.WriteLine("Press <Enter>...");
            Console.ReadLine();
        }
    }
}
