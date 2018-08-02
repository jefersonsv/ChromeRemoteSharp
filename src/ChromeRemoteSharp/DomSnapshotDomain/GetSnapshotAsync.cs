using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomSnapshotDomain
{
    public partial class DomSnapshotDomain
    {
        /// <summary>
        /// Returns a document snapshot, including the full DOM tree of the root node (including iframes, template contents, and imported documents) in a flattened array, as well as layout and white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is flattened.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMSnapshot#method-getSnapshot"/>
        /// </summary>
        /// <param name="computedStyleWhitelist">Whitelist of computed styles to return.</param>
        /// <param name="includeEventListeners">Whether or not to retrieve details of DOM listeners (default false).</param>
        /// <param name="includePaintOrder">Whether to determine and include the paint order index of LayoutTreeNodes (default false).</param>
        /// <param name="includeUserAgentShadowTree">Whether to include UA shadow tree in the snapshot (default false).</param>
        /// <returns></returns>
        public async Task<JObject> GetSnapshotAsync(string[] computedStyleWhitelist, bool? includeEventListeners = null, bool? includePaintOrder = null, bool? includeUserAgentShadowTree = null)
        {
            return await CommandAsync("getSnapshot", 
                 new KeyValuePair<string, object>("computedStyleWhitelist", computedStyleWhitelist), 
                 new KeyValuePair<string, object>("includeEventListeners", includeEventListeners), 
                 new KeyValuePair<string, object>("includePaintOrder", includePaintOrder), 
                 new KeyValuePair<string, object>("includeUserAgentShadowTree", includeUserAgentShadowTree)
                 );
        }
    }
}
