﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NLog;
using Refuctor.Objects;

namespace Refuctor
{
    public class WordReplacer
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public FileInfo FileInfo { get; set; }

        public bool IsTestMode { get; set; }
        
        public List<Term> Terms { get; private set; }
        
        public WordReplacer(FileInfo file, bool isTestMode, List<Term> terms)
        {
            FileInfo = file;
            IsTestMode = isTestMode;
            Terms = terms;
        }

        public void Go()
        {
            Log.Info(FileInfo.FullName);
            var lines = File.ReadAllLines(FileInfo.FullName);
            var newLines = new List<string>();
            bool touched = false;
            for (int i = 0; i < lines.Length; i++)
            {
                int lineNumber = i+1;
                string updatedLine = lines[i];
                foreach (var term in Terms)
                {
                    var permutatedTerms = term.GetPermutations();
                    foreach (var permutatedTerm in permutatedTerms)
                    {
                        updatedLine = updatedLine.Replace(permutatedTerm.Target, permutatedTerm.ReplaceWith);
                    }
                }

                if (string.Compare(lines[i], updatedLine) != 0)
                {
                    Log.Info("Line {0}\r\n{1}\r\n{2}", lineNumber, lines[i], updatedLine);
                    touched = true;
                }

                newLines.Add(updatedLine);
            }

            if (!IsTestMode && touched)
            {
                FileInfo.Delete();
                File.WriteAllLines(FileInfo.FullName, newLines.ToArray());
            }
        }
    }
}
