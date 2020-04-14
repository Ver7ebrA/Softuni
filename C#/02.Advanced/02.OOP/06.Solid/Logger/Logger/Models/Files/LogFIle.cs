using System;
using System.IO;
using System.Linq;
using System.Globalization;

using Logger.Models.Contracts;
using Logger.Models.IOManagment;
using Logger.Models.Enimerations;

namespace Logger.Models.Files
{
    public class LogFIle : IFile
    {
        private IIOManager IOManager;
        private object message;

        public LogFIle(string folderName, string fileName)
        {
            this.IOManager = new IOManager(folderName, fileName);
            this.IOManager.EnsureDirectoryAndFileExist();
        }

        public string Path => this.IOManager.CurrentFilePath;

        public long Size => this.GetFIleSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            Level level = error.Level;

            string formatedMessage = String.Format(format,
                dateTime.ToString("M/dd/yyyy :mm:ss tt",
                CultureInfo.InvariantCulture),
                message,
                level.ToString()) + Environment.NewLine;

            return formatedMessage;
        }

        private long GetFIleSize()
        {
            string text = File.ReadAllText(this.Path);

            long size = text
                .Where(ch => Char.IsLetter(ch))
                .Sum(ch => ch);

            return size;
        }
    }
}
