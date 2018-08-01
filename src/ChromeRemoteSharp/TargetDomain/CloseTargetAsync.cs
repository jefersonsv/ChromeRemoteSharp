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
        /// Closes the target. If the target is a page that gets closed too.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#closeTarget"/>
        /// </summary>
        /// <param name="targetId"></param>
        /// <returns></returns>
        public async Task<JObject> CloseTargetAsync(string targetId)
        {
            return await CommandAsync("closeTarget", 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
