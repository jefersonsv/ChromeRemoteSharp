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
        /// Deletes browser cookie with given name, domain and path.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-deleteCookie"/>
        /// </summary>
        /// <param name="cookieName">Name of the cookie to remove.</param>
        /// <param name="url">URL to match cooke domain and path.</param>
        /// <returns></returns>
        public async Task<JObject> DeleteCookieAsync(string cookieName, string url)
        {
            return await CommandAsync("deleteCookie", 
                 new KeyValuePair<string, object>("cookieName", cookieName), 
                 new KeyValuePair<string, object>("url", url)
                 );
        }
    }
}
