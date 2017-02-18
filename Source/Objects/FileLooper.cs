using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using NLog;

namespace Refuctor.Objects
{
    class FileLooper
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public bool IsTestMode { get;set; }

        public string RootPath { get; set; }

        public List<FileExtension> Extensions { get; private set; }

        public List<Term> Terms { get; private set; }

        public List<string> AntiFileTerms { get; private set; }

        public FileLooper()
        {
            Terms = new List<Term>();

            Extensions = new List<FileExtension>();
            Extensions = new List<FileExtension>();
            //Extensions.Add(new FileExtension(".cs"));
            //Extensions.Add(new FileExtension(".cshtml"));
            //Extensions.Add(new FileExtension(".sql"));
            Extensions.Add(new FileExtension(".csproj"));
            //Extensions.Add(new FileExtension(".sqlproj"));

            AntiFileTerms = new List<string>();
            //AntiFileTerms.Add("_ReSharper");
            AntiFileTerms.Add(".git");
        }

        public void Go()
        {
            Log.Info("==========================================================================================================================");
          //  foreach (var term in Terms)
            {
               // ProcessDirs(term);
                ProcessFiles();   
            }
        }

        private void ProcessDirs(Term term)
        {
            var dirList = Directory.GetDirectories(RootPath, "*.*", SearchOption.AllDirectories);

            foreach (var dir in dirList)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                bool antiMatch = AntiFileTerms.Any(t => dirInfo.FullName.Contains(t));

                if (!antiMatch)
                {
                    var dirRenamer = new DirectoryRenamer(dirInfo, IsTestMode, new List<Term> { term });
                    dirRenamer.Go();
                }
            }
        }

        private void ProcessFiles()
        {
            var fileList = Directory.GetFiles(RootPath, "*.*", SearchOption.AllDirectories);
           
            foreach (var file in fileList)
            {
                FileInfo fileInfo = new FileInfo(file);
                bool extensionMatch = Extensions.Contains(new FileExtension(fileInfo.Extension));
                bool antiMatch =  AntiFileTerms.Any(t => fileInfo.FullName.Contains(t));

                if (extensionMatch && !antiMatch)
                {

                    //var wordReplacer = new WordReplacer(fileInfo, IsTestMode, new List<Term> { term });
                    //wordReplacer.Go();

                    //var fileRenamer = new FileRenamer(fileInfo, IsTestMode, new List<Term> { term });
                    //fileRenamer.Go();

                    Log.Info($"Processing {fileInfo.Name}");
                    var replacer = new RegexReplacer(fileInfo, IsTestMode);
                    replacer.Go();
                }
                else
                {
                    Log.Trace("Skipping {0}", fileInfo.FullName);
                }
            }
        }
    }
}
