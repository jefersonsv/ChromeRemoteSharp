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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#method-inspectWorker"/>
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        public async Task<JObject> InspectWorkerAsync(string versionId)
        {
            return await CommandAsync("inspectWorker", 
                 new KeyValuePair<string, object>("versionId", versionId)
                 );
        }
    }
}
