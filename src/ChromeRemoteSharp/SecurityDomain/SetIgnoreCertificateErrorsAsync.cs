using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.SecurityDomain
{
    public partial class SecurityDomain
    {
        /// <summary>
        /// Enable/disable whether all certificate errors should be ignored.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security#method-setIgnoreCertificateErrors"/>
        /// </summary>
        /// <param name="ignore">If true, all certificate errors will be ignored.</param>
        /// <returns></returns>
        public async Task<JObject> SetIgnoreCertificateErrorsAsync(bool ignore)
        {
            return await CommandAsync("setIgnoreCertificateErrors", 
                 new KeyValuePair<string, object>("ignore", ignore)
                 );
        }
    }
}
