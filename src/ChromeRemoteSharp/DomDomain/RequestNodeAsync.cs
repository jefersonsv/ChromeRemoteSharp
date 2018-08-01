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
        /// Requests that the node is sent to the caller given the JavaScript node object reference. All nodes that form the path from the node to the root are also sent to the client as a series of `setChildNodes` notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#requestNode"/>
        /// </summary>
        /// <param name="objectId">JavaScript object id to convert into node.</param>
        /// <returns></returns>
        public async Task<JObject> RequestNodeAsync(string objectId)
        {
            return await CommandAsync("requestNode", 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
