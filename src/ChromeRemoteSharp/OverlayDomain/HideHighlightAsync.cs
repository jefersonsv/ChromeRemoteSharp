using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain
    {
        /// <summary>
        /// Hides any highlight.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#hideHighlight"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> HideHighlightAsync()
        {
            return await CommandAsync("hideHighlight");
        }
    }
}
