using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-setCustomObjectFormatterEnabled"/>
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public async Task<JObject> SetCustomObjectFormatterEnabledAsync(bool enabled)
        {
            return await CommandAsync("setCustomObjectFormatterEnabled", 
                 new KeyValuePair<string, object>("enabled", enabled)
                 );
        }
    }
}
