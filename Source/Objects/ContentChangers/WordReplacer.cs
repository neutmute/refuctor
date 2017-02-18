using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NLog;
using Refuctor.Objects;
using System.Text.RegularExpressions;

namespace Refuctor
{
    public abstract class ContentChanger
    {
        private static readonly Logger _log = LogManager.GetCurrentClassLogger();

        protected Logger Log => _log;

        protected FileInfo FileInfo { get; set; }

        public bool IsTestMode { get; set; }
        
        public ContentChanger(FileInfo file, bool isTestMode)
        {
            FileInfo = file;
            IsTestMode = isTestMode;
        }

        protected abstract string GetNewContent();

        protected string[] GetOriginalContentAsLines()
        {
            return File.ReadAllLines(FileInfo.FullName);
        }

        protected string GetOriginalContent()
        {
            return File.ReadAllText(FileInfo.FullName);
        }

        public void Go()
        {
            var newContent = GetNewContent();
            if (!IsTestMode && newContent != File.ReadAllText(FileInfo.FullName))
            {
                Log.Info($"Updated {FileInfo.FullName}");
                FileInfo.Delete();
                File.WriteAllText(FileInfo.FullName, newContent);
            }
        }
    }

    public class RegexReplacer : ContentChanger
    {
        public RegexReplacer(FileInfo file, bool isTestMode) : base(file, isTestMode)
        {

        }

        protected override string GetNewContent()
        {
            var originalContent = GetOriginalContent();
            var newContent = originalContent;

            string regex = @"(?<NoneBlock><None Include=""(?<IncludePath>[\w.\\]*)(?<BeforeLink>[ \w="".\\>\n</]+)<Link>(?<LinkContent>[\w.]*)</Link>[ \w="".\\>\n</]*</None>)";
            var myRegex = new Regex(regex, RegexOptions.None);
            
            foreach (Match noneBlockMatch in myRegex.Matches(originalContent))
            {
                if (noneBlockMatch.Success)
                {
                    var noneBlock = noneBlockMatch.Groups["NoneBlock"].Value;
                    var linkContent = noneBlockMatch.Groups["LinkContent"]?.Value;
                    if (!string.IsNullOrEmpty(linkContent))
                    {
                        var includePath = noneBlockMatch.Groups["IncludePath"].Value;

                        var newNoneBlock = noneBlock.Replace("<CopyAlways><CopyToOutputDirectory>Always</CopyToOutputDirectory>\r\n", string.Empty);
                        newContent = originalContent.Replace(noneBlock, newNoneBlock);

                        var includeName = Path.GetFileName(includePath);
                        if (!string.Equals(includeName, linkContent, StringComparison.OrdinalIgnoreCase))
                        {
                            Log.Warn($"{FileInfo.Name}: {includeName} linked to different file: {linkContent}");
                        }
                    }
                }
            }

            return newContent;
        }
    }

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
