using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain
    {
        /// <summary>
        /// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets the current virtual time policy.  Note this supersedes any previous time budget.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-setVirtualTimePolicy"/>
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="budget">If set, after this many virtual milliseconds have elapsed virtual time will be paused and a virtualTimeBudgetExpired event is sent.</param>
        /// <param name="maxVirtualTimeTaskStarvationCount">If set this specifies the maximum number of tasks that can be run before virtual is forced forwards to prevent deadlock.</param>
        /// <param name="waitForNavigation">If set the virtual time policy change should be deferred until any frame starts navigating. Note any previous deferred policy change is superseded.</param>
        /// <param name="initialVirtualTime">If set, base::Time::Now will be overriden to initially return this value.</param>
        /// <returns></returns>
        public async Task<JObject> SetVirtualTimePolicyAsync(string policy, int? budget = null, string maxVirtualTimeTaskStarvationCount = null, bool? waitForNavigation = null, string initialVirtualTime = null)
        {
            return await CommandAsync("setVirtualTimePolicy", 
                 new KeyValuePair<string, object>("policy", policy), 
                 new KeyValuePair<string, object>("budget", budget), 
                 new KeyValuePair<string, object>("maxVirtualTimeTaskStarvationCount", maxVirtualTimeTaskStarvationCount), 
                 new KeyValuePair<string, object>("waitForNavigation", waitForNavigation), 
                 new KeyValuePair<string, object>("initialVirtualTime", initialVirtualTime)
                 );
        }
    }
}
