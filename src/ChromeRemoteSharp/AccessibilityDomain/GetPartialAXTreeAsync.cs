using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AccessibilityDomain
{
    public partial class AccessibilityDomain
    {
        /// <summary>
        /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Accessibility#getPartialAXTree"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetPartialAXTreeAsync()
        {
            return await CommandAsync("getPartialAXTree");
        }
    }
}
