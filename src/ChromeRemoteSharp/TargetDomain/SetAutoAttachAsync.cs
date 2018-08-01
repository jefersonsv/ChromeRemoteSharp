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
        /// Controls whether to automatically attach to new targets which are considered to be related to this one. When turned on, attaches to all existing related targets as well. When turned off, automatically detaches from all currently attached targets.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#setAutoAttach"/>
        /// </summary>
        /// <param name="autoAttach">Whether to auto-attach to related targets.</param>
        /// <param name="waitForDebuggerOnStart">Whether to pause new targets when attaching to them. Use `Runtime.runIfWaitingForDebugger` to run paused targets.</param>
        /// <param name="flatten">Enables "flat" access to the session via specifying sessionId attribute in the commands.</param>
        /// <returns></returns>
        public async Task<JObject> SetAutoAttachAsync(bool autoAttach,bool waitForDebuggerOnStart,bool? flatten)
        {
            return await CommandAsync("setAutoAttach", 
                 new KeyValuePair<string, object>("autoAttach", autoAttach), 
                 new KeyValuePair<string, object>("waitForDebuggerOnStart", waitForDebuggerOnStart), 
                 new KeyValuePair<string, object>("flatten", flatten)
                 );
        }
    }
}
