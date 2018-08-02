using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TracingDomain
{
    public partial class TracingDomain
    {
        /// <summary>
        /// Gets supported tracing categories.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing#method-getCategories"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetCategoriesAsync()
        {
            return await CommandAsync("getCategories");
        }
    }
}
