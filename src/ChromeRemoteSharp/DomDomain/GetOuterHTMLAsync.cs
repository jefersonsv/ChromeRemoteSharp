using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// <seealso cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getOuterHTML"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetOuterHtmlAsync(int nodeId)
        {
            return await CommandAsync("getOuterHTML", 
                new KeyValuePair<string, object>("nodeId", nodeId)
                );
        }
    }
}
