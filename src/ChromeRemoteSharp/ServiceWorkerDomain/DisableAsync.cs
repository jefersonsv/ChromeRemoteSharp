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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
