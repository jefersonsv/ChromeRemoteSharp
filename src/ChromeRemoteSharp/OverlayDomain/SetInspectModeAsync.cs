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
        /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setInspectMode"/>
        /// </summary>
        /// <param name="mode">Set an inspection mode.</param>
        /// <param name="highlightConfig">A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled == false`.</param>
        /// <returns></returns>
        public async Task<JObject> SetInspectModeAsync(string mode,string highlightConfig)
        {
            return await CommandAsync("setInspectMode", 
                 new KeyValuePair<string, object>("mode", mode), 
                 new KeyValuePair<string, object>("highlightConfig", highlightConfig)
                 );
        }
    }
}
