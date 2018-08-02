using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Returns iframe node that owns iframe with the given domain.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getFrameOwner"/>
        /// </summary>
        /// <param name="frameId"></param>
        /// <returns></returns>
        public async Task<JObject> GetFrameOwnerAsync(string frameId)
        {
            return await CommandAsync("getFrameOwner", 
                 new KeyValuePair<string, object>("frameId", frameId)
                 );
        }
    }
}
