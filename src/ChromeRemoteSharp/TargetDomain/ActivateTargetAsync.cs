using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Activates (focuses) the target.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-activateTarget"/>
        /// </summary>
        /// <param name="targetId"></param>
        /// <returns></returns>
        public async Task<JObject> ActivateTargetAsync(string targetId)
        {
            return await CommandAsync("activateTarget", 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
