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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#deliverPushMessage"/>
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="registrationId"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<JObject> DeliverPushMessageAsync(string origin,string registrationId,string data)
        {
            return await CommandAsync("deliverPushMessage", 
                 new KeyValuePair<string, object>("origin", origin), 
                 new KeyValuePair<string, object>("registrationId", registrationId), 
                 new KeyValuePair<string, object>("data", data)
                 );
        }
    }
}
