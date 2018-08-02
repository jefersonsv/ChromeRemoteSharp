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
        /// Attaches to the target with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-attachToTarget"/>
        /// </summary>
        /// <param name="targetId"></param>
        /// <param name="flatten">Enables "flat" access to the session via specifying sessionId attribute in the commands.</param>
        /// <returns></returns>
        public async Task<JObject> AttachToTargetAsync(string targetId, bool? flatten = null)
        {
            return await CommandAsync("attachToTarget", 
                 new KeyValuePair<string, object>("targetId", targetId), 
                 new KeyValuePair<string, object>("flatten", flatten)
                 );
        }
    }
}
