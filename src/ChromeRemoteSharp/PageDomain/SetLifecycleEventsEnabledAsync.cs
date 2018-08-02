using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Controls whether page will emit lifecycle events.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setLifecycleEventsEnabled"/>
        /// </summary>
        /// <param name="enabled">If true, starts emitting lifecycle events.</param>
        /// <returns></returns>
        public async Task<JObject> SetLifecycleEventsEnabledAsync(bool enabled)
        {
            return await CommandAsync("setLifecycleEventsEnabled", 
                 new KeyValuePair<string, object>("enabled", enabled)
                 );
        }
    }
}
