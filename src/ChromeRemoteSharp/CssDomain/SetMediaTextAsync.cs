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
        /// Modifies the rule selector.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#setMediaText"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <param name="range"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<JObject> SetMediaTextAsync(string styleSheetId,string range,string text)
        {
            return await CommandAsync("setMediaText", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId), 
                 new KeyValuePair<string, object>("range", range), 
                 new KeyValuePair<string, object>("text", text)
                 );
        }
    }
}
