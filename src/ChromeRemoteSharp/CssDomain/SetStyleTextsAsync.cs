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
        /// Applies specified style edits one after another in the given order.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-setStyleTexts"/>
        /// </summary>
        /// <param name="edits"></param>
        /// <returns></returns>
        public async Task<JObject> SetStyleTextsAsync(string[] edits)
        {
            return await CommandAsync("setStyleTexts", 
                 new KeyValuePair<string, object>("edits", edits)
                 );
        }
    }
}
