using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Refuctor
{
    class FileRenamer
    {
        public FileInfo FileInfo { get; set; }

        public bool IsTestMode { get; set; }
        
        public List<Term> Terms { get; private set; }
        
        public FileRenamer(FileInfo file, bool isTestMode, List<Term> terms)
        {
            
        }

        public void Go()
        {
            
        }
    }
}
