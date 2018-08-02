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
        /// Close the stream, discard any temporary backing storage.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IO#method-close"/>
        /// </summary>
        /// <param name="handle">Handle of the stream to close.</param>
        /// <returns></returns>
        public async Task<JObject> CloseAsync(string handle)
        {
            return await CommandAsync("close", 
                 new KeyValuePair<string, object>("handle", handle)
                 );
        }
    }
}
