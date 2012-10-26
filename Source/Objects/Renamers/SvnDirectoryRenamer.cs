using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kraken.Framework.Core;
using NLog;
using Refuctor.Objects.Renamers;

namespace Refuctor
{
    class DirectoryRenamer : SvnRenamer
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public DirectoryInfo DirectoryInfo { get; set; }

        public DirectoryRenamer(DirectoryInfo Directory, bool isTestMode, List<Term> terms)
        {

        }

        public void Go()
        {
            foreach (var term in Terms)
            {
                if (DirectoryInfo.Name.Contains(term.Target))
                {
                    var newName = DirectoryInfo.Name.Replace(term.Target, term.ReplaceWith);

                    Log.Info("Renaming directory {0} to {1}", DirectoryInfo.FullName, newName);
                    if (!IsTestMode)
                    {
                        WorkingDirectory = DirectoryInfo.Parent.FullName;
                        Arguments = string.Format("rename {0} {1}", DirectoryInfo.Name, newName);
                        int errorLevel = StartWithWait();

                        if (errorLevel != 0)
                        {
                            throw KrakenException.Create("Error level returned as {0}", errorLevel);
                        }
                    }
                }
            }

        }
    }
}
