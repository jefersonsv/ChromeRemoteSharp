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
        /// Switches script execution in the page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setScriptExecutionDisabled"/>
        /// </summary>
        /// <param name="value">Whether script execution should be disabled in the page.</param>
        /// <returns></returns>
        public async Task<JObject> SetScriptExecutionDisabledAsync(bool value)
        {
            return await CommandAsync("setScriptExecutionDisabled", 
                 new KeyValuePair<string, object>("value", value)
                 );
        }
    }
}
