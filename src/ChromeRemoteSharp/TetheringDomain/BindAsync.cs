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
        /// Request browser port binding.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tethering#bind"/>
        /// </summary>
        /// <param name="port">Port number to bind.</param>
        /// <returns></returns>
        public async Task<JObject> BindAsync(string port)
        {
            return await CommandAsync("bind", 
                 new KeyValuePair<string, object>("port", port)
                 );
        }
    }
}
