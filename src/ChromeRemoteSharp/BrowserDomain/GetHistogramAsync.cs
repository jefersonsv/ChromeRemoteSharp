using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.BrowserDomain
{
    public partial class BrowserDomain
    {
        /// <summary>
        /// Get a Chrome histogram by name.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getHistogram"/>
        /// </summary>
        /// <param name="name">Requested histogram name.</param>
        /// <param name="delta">If true, retrieve delta since last call.</param>
        /// <returns></returns>
        public async Task<JObject> GetHistogramAsync(string name, bool? delta = null)
        {
            return await CommandAsync("getHistogram", 
                 new KeyValuePair<string, object>("name", name), 
                 new KeyValuePair<string, object>("delta", delta)
                 );
        }
    }
}
