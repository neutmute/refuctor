using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.Framework.Core;

namespace Refuctor.Objects.Renamers
{
    class SvnRenamer : KrakenProcess
    {


        public bool IsTestMode { get; set; }

        public List<Term> Terms { get; private set; }

        public SvnRenamer(bool isTestMode, List<Term> terms)
        {
            IsTestMode = isTestMode;
            Terms = terms;
        }

        protected void SvnRename()
        {
            FriendlyName = "SVN Rename";
            Filename = @"C:\Program Files\TortoiseSVN\bin\Svn.exe";
        }
    }
}
