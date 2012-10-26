using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using Refuctor.Objects;

namespace Refuctor
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var looper = new FileLooper();
            looper.RootPath = @"C:\Code\Application\Kraken";
            looper.IsTestMode = true;

            looper.Terms.Add(new Term { Target = "Metric Reading", ReplaceWith = "Metric Value" });
            looper.Terms.Add(new Term { Target = "Mib Reading", ReplaceWith = "Mib Value" });
            looper.Terms.Add(new Term { Target = "MetricReading", ReplaceWith = "MetricValue" });
            looper.Terms.Add(new Term { Target = "DeviceReading", ReplaceWith = "DeviceValue" });
            looper.Terms.Add(new Term { Target = "MibReading", ReplaceWith = "MibValue" });
            looper.Terms.Add(new Term {Target = "MetricScan", ReplaceWith = "MetricReading"});
            looper.Terms.Add(new Term { Target = "MibScan", ReplaceWith = "MibReading" });
            

            looper.Go();
        }
    }
}
