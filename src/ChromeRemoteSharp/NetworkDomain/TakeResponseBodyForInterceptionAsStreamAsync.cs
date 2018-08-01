using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Returns a handle to the stream representing the response body. Note that after this command, the intercepted request can't be continued as is -- you either need to cancel it or to provide the response body. The stream only supports sequential read, IO.read will fail if the position is specified.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#takeResponseBodyForInterceptionAsStream"/>
        /// </summary>
        /// <param name="interceptionId"></param>
        /// <returns></returns>
        public async Task<JObject> TakeResponseBodyForInterceptionAsStreamAsync(string interceptionId)
        {
            return await CommandAsync("takeResponseBodyForInterceptionAsStream", 
                 new KeyValuePair<string, object>("interceptionId", interceptionId)
                 );
        }
    }
}
