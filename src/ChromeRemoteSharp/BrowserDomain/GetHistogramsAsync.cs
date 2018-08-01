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
        /// Get Chrome histograms.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#getHistograms"/>
        /// </summary>
        /// <param name="query">Requested substring in name. Only histograms which have query as a substring in their name are extracted. An empty or absent query returns all histograms.</param>
        /// <param name="delta">If true, retrieve delta since last call.</param>
        /// <returns></returns>
        public async Task<JObject> GetHistogramsAsync(string query,bool? delta)
        {
            return await CommandAsync("getHistograms", 
                 new KeyValuePair<string, object>("query", query), 
                 new KeyValuePair<string, object>("delta", delta)
                 );
        }
    }
}
