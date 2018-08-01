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
        /// Returns the DER-encoded certificate.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#getCertificate"/>
        /// </summary>
        /// <param name="origin">Origin to get certificate for.</param>
        /// <returns></returns>
        public async Task<JObject> GetCertificateAsync(string origin)
        {
            return await CommandAsync("getCertificate", 
                 new KeyValuePair<string, object>("origin", origin)
                 );
        }
    }
}
