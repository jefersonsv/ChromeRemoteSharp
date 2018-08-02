using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDebuggerDomain
{
    public partial class DomDebuggerDomain
    {
        /// <summary>
        /// Returns event listeners of the given object.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMDebugger#method-getEventListeners"/>
        /// </summary>
        /// <param name="objectId">Identifier of the object to return listeners for.</param>
        /// <param name="depth">The maximum depth at which Node children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.</param>
        /// <param name="pierce">Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false). Reports listeners for all contexts if pierce is enabled.</param>
        /// <returns></returns>
        public async Task<JObject> GetEventListenersAsync(string objectId, string depth = null, bool? pierce = null)
        {
            return await CommandAsync("getEventListeners", 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("depth", depth), 
                 new KeyValuePair<string, object>("pierce", pierce)
                 );
        }
    }
}
