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
        /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#getLayoutMetrics"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetLayoutMetricsAsync()
        {
            return await CommandAsync("getLayoutMetrics");
        }
    }
}
