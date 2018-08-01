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
        /// Returns the current textual content for a stylesheet.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getStyleSheetText"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <returns></returns>
        public async Task<JObject> GetStyleSheetTextAsync(string styleSheetId)
        {
            return await CommandAsync("getStyleSheetText", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId)
                 );
        }
    }
}
