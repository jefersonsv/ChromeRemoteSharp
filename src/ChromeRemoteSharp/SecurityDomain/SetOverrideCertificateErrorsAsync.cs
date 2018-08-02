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
        /// Enable/disable overriding certificate errors. If enabled, all certificate error events need to be handled by the DevTools client and should be answered with `handleCertificateError` commands.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security#method-setOverrideCertificateErrors"/>
        /// </summary>
        /// <param name="override">If true, certificate errors will be overridden.</param>
        /// <returns></returns>
        public async Task<JObject> SetOverrideCertificateErrorsAsync(bool canoverride)
        {
            return await CommandAsync("setOverrideCertificateErrors", 
                 new KeyValuePair<string, object>("override", canoverride)
                 );
        }
    }
}
