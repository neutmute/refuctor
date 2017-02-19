using System.IO;
using NLog;

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
}