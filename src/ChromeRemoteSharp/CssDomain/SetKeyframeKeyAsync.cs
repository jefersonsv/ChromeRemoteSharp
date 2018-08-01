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
        /// Modifies the keyframe rule key text.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#setKeyframeKey"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <param name="range"></param>
        /// <param name="keyText"></param>
        /// <returns></returns>
        public async Task<JObject> SetKeyframeKeyAsync(string styleSheetId,string range,string keyText)
        {
            return await CommandAsync("setKeyframeKey", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId), 
                 new KeyValuePair<string, object>("range", range), 
                 new KeyValuePair<string, object>("keyText", keyText)
                 );
        }
    }
}
