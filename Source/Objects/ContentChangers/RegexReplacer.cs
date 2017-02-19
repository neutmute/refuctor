using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Refuctor
{
    public class RegexReplacer : ContentChanger
    {
        public RegexReplacer(FileInfo file, bool isTestMode) : base(file, isTestMode)
        {

        }

        protected override string GetNewContent()
        {
            var originalContent = GetOriginalContent();
            var newContent = originalContent;

            string regex = @"(?<NoneBlock><None Include=""(?<IncludePath>[^""]*?)"">(?<BeforeLink>[ \w="".\\>\r\n</]*?)<Link>(?<LinkContent>[\w.]*?)</Link>(?<BeforeDependentUpon>[ \w="".\\>\r\n</]*?)<DependentUpon>(?<DependentUponContent>[\w.]*?)</DependentUpon>" + "\n" + @"[ \w="".\\>\r\n</]*?</None>)";

            var myRegex = new Regex(regex, RegexOptions.None);
            
            foreach (Match noneBlockMatch in myRegex.Matches(originalContent))
            {
                if (noneBlockMatch.Success)
                {
                    var noneBlock = noneBlockMatch.Groups["NoneBlock"].Value;
                    var linkContent = noneBlockMatch.Groups["LinkContent"]?.Value;
                    var dependentUponContent = noneBlockMatch.Groups["DependentUponContent"]?.Value;
                    var isTransformFile = noneBlock.Contains("<IsTransformFile>True</IsTransformFile>");
                    if (isTransformFile && !string.IsNullOrEmpty(linkContent))
                    {
                        var includePath = noneBlockMatch.Groups["IncludePath"].Value;

                        var newNoneBlock = noneBlock.Replace("<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>\r\n", string.Empty);
                        newNoneBlock = newNoneBlock.Replace("          </None>", "    </None>");
                        newContent = newContent.Replace(noneBlock, newNoneBlock);

                        var includeName = Path.GetFileName(includePath);
                        if (!string.Equals(includeName, dependentUponContent, StringComparison.OrdinalIgnoreCase))
                        {
                            Log.Warn($"{FileInfo.Name}: {includeName} linked to different file: {linkContent}");
                        }
                    }
                }
            }

            return newContent;
        }
    }
}