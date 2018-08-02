using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.SchemaDomain
{
    public partial class SchemaDomain
    {
        /// <summary>
        /// Returns supported domains.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Schema#method-getDomains"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetDomainsAsync()
        {
            return await CommandAsync("getDomains");
        }
    }
}
