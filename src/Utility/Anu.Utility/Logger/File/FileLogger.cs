using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Utility.Logger.File
{
    public class FileLogger : ILogger
    {
        private readonly FileLoggerProvider _provider;
        private readonly string _categoryName;

        public FileLogger(FileLoggerProvider provider, string categoryName)
        {
            this._provider = provider;
            this._categoryName = categoryName;
        }
        public IDisposable BeginScope<TState>(TState state) => default!;


        public bool IsEnabled(LogLevel logLevel)
        {
            if (_provider.Options.Enabled == false || string.IsNullOrWhiteSpace(_provider.Options.Path))
            {
                return false;
            }

            return logLevel != LogLevel.None;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (this.IsEnabled(logLevel))
            {
                var now = DateTime.Now;
                var fileName = System.IO.Path.Combine(_provider.Options.Path, now.ToString("yyyy-MM-dd"), _categoryName.Replace('.', '\\'), logLevel.ToString(), $"{now.ToString("HH-mm")}.txt");
                var fi = new System.IO.FileInfo(fileName);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                var msg = formatter.Invoke(state, exception);
                lock (_provider)
                {

                    System.IO.File.AppendAllText(fileName, $"{msg}{Environment.NewLine}");
                }
            }

        }
    }
}
