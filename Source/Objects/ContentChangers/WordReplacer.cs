﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Refuctor.Objects;

namespace Refuctor
{
    public class WordReplacer : ContentChanger
    {       
        public List<Term> Terms { get; private set; }
        
        public WordReplacer(FileInfo file, bool isTestMode, List<Term> terms) : base(file, isTestMode)
        {
            Terms = terms;
        }

        protected override string GetNewContent()
        {
            
            var lines = GetOriginalContentAsLines();
            var newLines = new List<string>();
            //bool touched = false;
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

                    //if (!touched)
                    //{
                    //    Log.Info(FileInfo.FullName);
                    //}
                    //touched = true;
                }

                newLines.Add(updatedLine);
            }

            return string.Join("\r\n", newLines);
        }
    }
}
