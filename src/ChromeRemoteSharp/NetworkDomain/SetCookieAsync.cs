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
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-setCookie"/>
        /// </summary>
        /// <param name="name">Cookie name.</param>
        /// <param name="value">Cookie value.</param>
        /// <param name="url">The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.</param>
        /// <param name="domain">Cookie domain.</param>
        /// <param name="path">Cookie path.</param>
        /// <param name="secure">True if cookie is secure.</param>
        /// <param name="httpOnly">True if cookie is http-only.</param>
        /// <param name="sameSite">Cookie SameSite type.</param>
        /// <param name="expires">Cookie expiration date, session cookie if not set</param>
        /// <returns></returns>
        public async Task<JObject> SetCookieAsync(string name, string value, string url = null, string domain = null, string path = null, bool? secure = null, bool? httpOnly = null, string sameSite = null, string expires = null)
        {
            return await CommandAsync("setCookie", 
                 new KeyValuePair<string, object>("name", name), 
                 new KeyValuePair<string, object>("value", value), 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("domain", domain), 
                 new KeyValuePair<string, object>("path", path), 
                 new KeyValuePair<string, object>("secure", secure), 
                 new KeyValuePair<string, object>("httpOnly", httpOnly), 
                 new KeyValuePair<string, object>("sameSite", sameSite), 
                 new KeyValuePair<string, object>("expires", expires)
                 );
        }
    }
}
