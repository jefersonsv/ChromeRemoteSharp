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
        /// Returns all class names from specified stylesheet.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-collectClassNames"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <returns></returns>
        public async Task<JObject> CollectClassNamesAsync(string styleSheetId)
        {
            return await CommandAsync("collectClassNames", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId)
                 );
        }
    }
}
