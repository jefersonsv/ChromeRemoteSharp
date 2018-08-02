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
        /// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-createStyleSheet"/>
        /// </summary>
        /// <param name="frameId">Identifier of the frame where "via-inspector" stylesheet should be created.</param>
        /// <returns></returns>
        public async Task<JObject> CreateStyleSheetAsync(string frameId)
        {
            return await CommandAsync("createStyleSheet", 
                 new KeyValuePair<string, object>("frameId", frameId)
                 );
        }
    }
}
