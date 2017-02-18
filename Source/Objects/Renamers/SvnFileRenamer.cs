using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Kraken.Core;
using NLog;
using Refuctor.Objects.Renamers;

namespace Refuctor
{
    class FileRenamer : SvnRenamer
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public FileInfo FileInfo { get; set; }
        
        public FileRenamer(FileInfo file, bool isTestMode, List<Term> terms) : base(isTestMode, terms)
        {
            FileInfo = file;
        }

        public void Go()
        {
             foreach (var term in Terms)
             {
                if (FileInfo.Name.Contains(term.Target))
                {
                    var newName = FileInfo.Name.Replace(term.Target, term.ReplaceWith);

                    Log.Info("Renaming {0} to {1}", FileInfo.FullName, newName);
                    if (!IsTestMode)
                    {
                        WorkingDirectory = FileInfo.DirectoryName;
                        Arguments = string.Format("rename {0} {1}", FileInfo.Name, newName);
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
