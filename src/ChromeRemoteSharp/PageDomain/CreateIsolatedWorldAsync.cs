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
        /// Creates an isolated world for the given frame.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-createIsolatedWorld"/>
        /// </summary>
        /// <param name="frameId">Id of the frame in which the isolated world should be created.</param>
        /// <param name="worldName">An optional name which is reported in the Execution Context.</param>
        /// <param name="grantUniveralAccess">Whether or not universal access should be granted to the isolated world. This is a powerful option, use with caution.</param>
        /// <returns></returns>
        public async Task<JObject> CreateIsolatedWorldAsync(string frameId, string worldName = null, bool? grantUniveralAccess = null)
        {
            return await CommandAsync("createIsolatedWorld", 
                 new KeyValuePair<string, object>("frameId", frameId), 
                 new KeyValuePair<string, object>("worldName", worldName), 
                 new KeyValuePair<string, object>("grantUniveralAccess", grantUniveralAccess)
                 );
        }
    }
}
