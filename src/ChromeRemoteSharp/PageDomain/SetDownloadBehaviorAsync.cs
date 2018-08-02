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
        /// Set the behavior when downloading a file.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setDownloadBehavior"/>
        /// </summary>
        /// <param name="behavior">Whether to allow all or deny all download requests, or use default Chrome behavior if available (otherwise deny).</param>
        /// <param name="downloadPath">The default path to save downloaded files to. This is requred if behavior is set to 'allow'</param>
        /// <returns></returns>
        public async Task<JObject> SetDownloadBehaviorAsync(string behavior, string downloadPath = null)
        {
            return await CommandAsync("setDownloadBehavior", 
                 new KeyValuePair<string, object>("behavior", behavior), 
                 new KeyValuePair<string, object>("downloadPath", downloadPath)
                 );
        }
    }
}
