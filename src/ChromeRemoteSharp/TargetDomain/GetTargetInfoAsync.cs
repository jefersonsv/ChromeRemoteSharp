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
        /// Returns information about a target.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#getTargetInfo"/>
        /// </summary>
        /// <param name="targetId"></param>
        /// <returns></returns>
        public async Task<JObject> GetTargetInfoAsync(string targetId)
        {
            return await CommandAsync("getTargetInfo", 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
