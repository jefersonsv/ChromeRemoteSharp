using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getBackgroundColors"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to get background colors for.</param>
        /// <returns></returns>
        public async Task<JObject> GetBackgroundColorsAsync(string nodeId)
        {
            return await CommandAsync("getBackgroundColors", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
