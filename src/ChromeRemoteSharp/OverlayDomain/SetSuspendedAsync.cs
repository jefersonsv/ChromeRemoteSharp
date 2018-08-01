using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setSuspended"/>
        /// </summary>
        /// <param name="suspended">Whether overlay should be suspended and not consume any resources until resumed.</param>
        /// <returns></returns>
        public async Task<JObject> SetSuspendedAsync(bool suspended)
        {
            return await CommandAsync("setSuspended", 
                 new KeyValuePair<string, object>("suspended", suspended)
                 );
        }
    }
}
