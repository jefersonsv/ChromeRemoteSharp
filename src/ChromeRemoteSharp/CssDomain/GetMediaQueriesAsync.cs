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
        /// Returns all media queries parsed by the rendering engine.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getMediaQueries"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetMediaQueriesAsync()
        {
            return await CommandAsync("getMediaQueries");
        }
    }
}
