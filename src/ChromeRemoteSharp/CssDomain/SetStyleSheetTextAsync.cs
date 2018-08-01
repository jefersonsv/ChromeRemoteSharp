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
        /// Sets the new stylesheet text.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#setStyleSheetText"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<JObject> SetStyleSheetTextAsync(string styleSheetId,string text)
        {
            return await CommandAsync("setStyleSheetText", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId), 
                 new KeyValuePair<string, object>("text", text)
                 );
        }
    }
}
