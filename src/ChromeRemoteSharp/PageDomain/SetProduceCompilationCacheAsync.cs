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
        /// Forces compilation cache to be generated for every subresource script.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#setProduceCompilationCache"/>
        /// </summary>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public async Task<JObject> SetProduceCompilationCacheAsync(bool enabled)
        {
            return await CommandAsync("setProduceCompilationCache", 
                 new KeyValuePair<string, object>("enabled", enabled)
                 );
        }
    }
}
