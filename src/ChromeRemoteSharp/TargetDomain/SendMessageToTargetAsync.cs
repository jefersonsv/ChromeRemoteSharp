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
        /// Sends protocol message over session with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#sendMessageToTarget"/>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sessionId">Identifier of the session.</param>
        /// <param name="targetId">Deprecated.</param>
        /// <returns></returns>
        public async Task<JObject> SendMessageToTargetAsync(string message,string sessionId,string targetId)
        {
            return await CommandAsync("sendMessageToTarget", 
                 new KeyValuePair<string, object>("message", message), 
                 new KeyValuePair<string, object>("sessionId", sessionId), 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
