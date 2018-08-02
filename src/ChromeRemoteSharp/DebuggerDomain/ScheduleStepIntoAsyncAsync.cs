using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain
    {
        /// <summary>
        /// This method is deprecated - use Debugger.stepInto with breakOnAsyncCall and Debugger.pauseOnAsyncTask instead. Steps into next scheduled async task if any is scheduled before next pause. Returns success when async task is actually scheduled, returns error if no task were scheduled or another scheduleStepIntoAsync was called.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-scheduleStepIntoAsync"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ScheduleStepIntoAsyncAsync()
        {
            return await CommandAsync("scheduleStepIntoAsync");
        }
    }
}
