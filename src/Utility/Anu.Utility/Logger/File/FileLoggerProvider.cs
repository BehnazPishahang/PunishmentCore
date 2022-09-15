using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Utility.Logger.File
{
    [ProviderAlias("File")]
    public class FileLoggerProvider : ILoggerProvider
    {

        internal FileLoggerOptions Options { get; init; }
        public FileLoggerProvider(IOptions<FileLoggerOptions> options)
        {
            Options = options.Value;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(this, categoryName);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
