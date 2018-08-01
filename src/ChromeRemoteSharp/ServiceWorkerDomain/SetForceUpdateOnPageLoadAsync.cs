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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker#setForceUpdateOnPageLoad"/>
        /// </summary>
        /// <param name="forceUpdateOnPageLoad"></param>
        /// <returns></returns>
        public async Task<JObject> SetForceUpdateOnPageLoadAsync(bool forceUpdateOnPageLoad)
        {
            return await CommandAsync("setForceUpdateOnPageLoad", 
                 new KeyValuePair<string, object>("forceUpdateOnPageLoad", forceUpdateOnPageLoad)
                 );
        }
    }
}
