﻿using System;
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
            Extensions.Add(new FileExtension(".cs"));
            //Extensions.Add(new FileExtension(".config"));
            Extensions.Add(new FileExtension(".cshtml"));
            Extensions.Add(new FileExtension(".sql"));
            Extensions.Add(new FileExtension(".csproj"));
            Extensions.Add(new FileExtension(".sqlproj"));

            AntiFileTerms = new List<string>();
            AntiFileTerms.Add("_ReSharper");
        }

        public void Go()
        {
            Log.Info("==========================================================================================================================");
            var fileList = Directory.GetFiles(RootPath, "*.*", SearchOption.AllDirectories);

            foreach (var file in fileList)
            {
                FileInfo fileInfo = new FileInfo(file);
                bool extensionMatch = Extensions.Contains(new FileExtension(fileInfo.Extension));
                bool antiMatch =  AntiFileTerms.Any(t => fileInfo.FullName.Contains(t));

                if (extensionMatch && !antiMatch)
                {
                    //Log.Info("Processing {0}", fileInfo.FullName);

                    var wordReplacer = new WordReplacer(fileInfo, IsTestMode, Terms);
                    wordReplacer.Go();

                    var fileRenamer = new FileRenamer(fileInfo, IsTestMode, Terms);
                    fileRenamer.Go();

                }
                else
                {
                    Log.Trace("Skipping {0}", fileInfo.FullName);
                }
            }
        }
    }
}
