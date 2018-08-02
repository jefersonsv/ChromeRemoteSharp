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
        /// Handles a certificate error that fired a certificateError event.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security#method-handleCertificateError"/>
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        /// <param name="action">The action to take on the certificate error.</param>
        /// <returns></returns>
        public async Task<JObject> HandleCertificateErrorAsync(string eventId, string action)
        {
            return await CommandAsync("handleCertificateError", 
                 new KeyValuePair<string, object>("eventId", eventId), 
                 new KeyValuePair<string, object>("action", action)
                 );
        }
    }
}
