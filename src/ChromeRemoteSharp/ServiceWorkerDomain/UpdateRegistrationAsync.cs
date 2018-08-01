using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ServiceWorkerDomain
{
    public partial class ServiceWorkerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#updateRegistration"/>
        /// </summary>
        /// <param name="scopeURL"></param>
        /// <returns></returns>
        public async Task<JObject> UpdateRegistrationAsync(string scopeURL)
        {
            return await CommandAsync("updateRegistration", 
                 new KeyValuePair<string, object>("scopeURL", scopeURL)
                 );
        }
    }
}
