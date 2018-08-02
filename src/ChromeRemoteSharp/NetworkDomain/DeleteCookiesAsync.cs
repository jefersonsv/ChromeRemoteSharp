using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Deletes browser cookies with matching name and url or domain/path pair.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-deleteCookies"/>
        /// </summary>
        /// <param name="name">Name of the cookies to remove.</param>
        /// <param name="url">If specified, deletes all the cookies with the given name where domain and path match provided URL.</param>
        /// <param name="domain">If specified, deletes only cookies with the exact domain.</param>
        /// <param name="path">If specified, deletes only cookies with the exact path.</param>
        /// <returns></returns>
        public async Task<JObject> DeleteCookiesAsync(string name, string url = null, string domain = null, string path = null)
        {
            return await CommandAsync("deleteCookies", 
                 new KeyValuePair<string, object>("name", name), 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("domain", domain), 
                 new KeyValuePair<string, object>("path", path)
                 );
        }
    }
}
