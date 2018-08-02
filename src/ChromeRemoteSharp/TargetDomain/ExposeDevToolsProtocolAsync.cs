using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Inject object to the target's main frame that provides a communication channel with browser target.  Injected object will be available as `window[bindingName]`.  The object has the follwing API: - `binding.send(json)` - a method to send messages over the remote debugging protocol - `binding.onmessage = json => handleMessage(json)` - a callback that will be called for the protocol notifications and command responses.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-exposeDevToolsProtocol"/>
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="bindingName">Binding name, 'cdp' if not specified.</param>
        /// <returns></returns>
        public async Task<JObject> ExposeDevToolsProtocolAsync(string targetId, string bindingName = null)
        {
            return await CommandAsync("exposeDevToolsProtocol", 
                 new KeyValuePair<string, object>("targetId", targetId), 
                 new KeyValuePair<string, object>("bindingName", bindingName)
                 );
        }
    }
}
