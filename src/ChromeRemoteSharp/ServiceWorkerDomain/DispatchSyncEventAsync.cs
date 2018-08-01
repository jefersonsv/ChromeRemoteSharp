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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#dispatchSyncEvent"/>
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="registrationId"></param>
        /// <param name="tag"></param>
        /// <param name="lastChance"></param>
        /// <returns></returns>
        public async Task<JObject> DispatchSyncEventAsync(string origin,string registrationId,string tag,bool lastChance)
        {
            return await CommandAsync("dispatchSyncEvent", 
                 new KeyValuePair<string, object>("origin", origin), 
                 new KeyValuePair<string, object>("registrationId", registrationId), 
                 new KeyValuePair<string, object>("tag", tag), 
                 new KeyValuePair<string, object>("lastChance", lastChance)
                 );
        }
    }
}
