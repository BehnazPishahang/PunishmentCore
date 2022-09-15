using Microsoft.Extensions.Configuration;
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

        internal FileLoggerOptions Options { get; }
        internal IConfiguration Configuration { get; }

        public FileLoggerProvider(IOptions<FileLoggerOptions> options, IConfiguration configuration)
        {
            Options = options.Value;
            Configuration = configuration;
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
