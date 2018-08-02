using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TetheringDomain
{
    public partial class TetheringDomain
    {
        /// <summary>
        /// Request browser port unbinding.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tethering#method-unbind"/>
        /// </summary>
        /// <param name="port">Port number to unbind.</param>
        /// <returns></returns>
        public async Task<JObject> UnbindAsync(string port)
        {
            return await CommandAsync("unbind", 
                 new KeyValuePair<string, object>("port", port)
                 );
        }
    }
}
