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
        /// Requests that the node is sent to the caller given its path. // FIXME, use XPath
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-pushNodeByPathToFrontend"/>
        /// </summary>
        /// <param name="path">Path to node in the proprietary format.</param>
        /// <returns></returns>
        public async Task<JObject> PushNodeByPathToFrontendAsync(string path)
        {
            return await CommandAsync("pushNodeByPathToFrontend", 
                 new KeyValuePair<string, object>("path", path)
                 );
        }
    }
}
