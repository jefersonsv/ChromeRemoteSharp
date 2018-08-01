using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setDocumentCookieDisabled"/>
        /// </summary>
        /// <param name="disabled">Whether document.coookie API should be disabled.</param>
        /// <returns></returns>
        public async Task<JObject> SetDocumentCookieDisabledAsync(bool disabled)
        {
            return await CommandAsync("setDocumentCookieDisabled", 
                 new KeyValuePair<string, object>("disabled", disabled)
                 );
        }
    }
}
