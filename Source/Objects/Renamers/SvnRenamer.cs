using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kraken.Core;

namespace Refuctor.Objects.Renamers
{
    class SvnRenamer : KrakenProcess
    {


        public bool IsTestMode { get; set; }

        public List<Term> Terms { get; private set; }

        public SvnRenamer(bool isTestMode, List<Term> terms)
        {

            FriendlyName = "SVN Rename";
            Filename = @"C:\Program Files\TortoiseSVN\bin\Svn.exe";
            IsTestMode = isTestMode;
            Terms = terms;
        }

    }
}
