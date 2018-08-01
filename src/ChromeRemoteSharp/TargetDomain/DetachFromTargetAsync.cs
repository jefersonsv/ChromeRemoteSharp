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
        /// Detaches session with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#detachFromTarget"/>
        /// </summary>
        /// <param name="sessionId">Session to detach.</param>
        /// <param name="targetId">Deprecated.</param>
        /// <returns></returns>
        public async Task<JObject> DetachFromTargetAsync(string sessionId,string targetId)
        {
            return await CommandAsync("detachFromTarget", 
                 new KeyValuePair<string, object>("sessionId", sessionId), 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
