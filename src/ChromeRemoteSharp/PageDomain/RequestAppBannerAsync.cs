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
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#requestAppBanner"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> RequestAppBannerAsync()
        {
            return await CommandAsync("requestAppBanner");
        }
    }
}
