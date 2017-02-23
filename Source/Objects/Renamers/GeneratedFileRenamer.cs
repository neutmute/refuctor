using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Kraken.Core;
using NLog;
using Refuctor.Objects.Renamers;

namespace Refuctor
{
    public class GeneratedRenamer : FileRenamer2
    {
        protected override string GetNewName()
        {
            var fullName = FileInfo.FullName;
            if (FileInfo.Name.Contains(".Generated"))
            {
                var fileContent = File.ReadAllText(FileInfo.FullName);
                var classPattern = @"class (?<className>\w+)*[\s:]*?";
                var classRegex = new Regex(classPattern, RegexOptions.None);
                var className = classRegex.Match(fileContent).Groups["className"];
                fullName = Path.Combine(FileInfo.DirectoryName, $"{className}.cs");
            }
            return fullName;
        }
    }

    public abstract class FileRenamer2 : KrakenProcess
    {
        public static StringBuilder commands = new StringBuilder();
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public FileInfo FileInfo { get; set; }

        public bool IsTestMode { get; set; }

        protected FileRenamer2()
        {
            IsTestMode = true;
        }

        protected FileRenamer2(FileInfo file, bool isTestMode)
        {
            FileInfo = file;
            IsTestMode = isTestMode;
        }

        protected abstract string GetNewName();

        public void Go()
        {
            var newName = GetNewName();
            var newNameInfo = new FileInfo(newName);

            if (FileInfo.FullName != newName && !IsTestMode)
            {
                Log.Info("Renaming {0} to {1}", FileInfo.FullName, newName);

                WorkingDirectory = FileInfo.DirectoryName;
                Arguments = $"rename {FileInfo.FullName} {newNameInfo.Name}";

                commands.AppendLine(Arguments);

                int errorLevel = StartWithWait();

                if (errorLevel != 0)
                {
                    throw KrakenException.Create("Error level returned as {0}", errorLevel);
                }
            }
        }
    }
}
