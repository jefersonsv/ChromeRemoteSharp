using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.IODomain
{
    public partial class IODomain
    {
        /// <summary>
        /// Read a chunk of the stream
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IO#method-read"/>
        /// </summary>
        /// <param name="handle">Handle of the stream to read.</param>
        /// <param name="offset">Seek to the specified offset before reading (if not specificed, proceed with offset following the last read). Some types of streams may only support sequential reads.</param>
        /// <param name="size">Maximum number of bytes to read (left upon the agent discretion if not specified).</param>
        /// <returns></returns>
        public async Task<JObject> ReadAsync(string handle, string offset = null, string size = null)
        {
            return await CommandAsync("read", 
                 new KeyValuePair<string, object>("handle", handle), 
                 new KeyValuePair<string, object>("offset", offset), 
                 new KeyValuePair<string, object>("size", size)
                 );
        }
    }
}
