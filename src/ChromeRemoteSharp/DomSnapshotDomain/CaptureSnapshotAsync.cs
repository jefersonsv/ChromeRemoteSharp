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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomSnapshot#captureSnapshot"/>
        /// </summary>
        /// <param name="computedStyles">Whitelist of computed styles to return.</param>
        /// <returns></returns>
        public async Task<JObject> CaptureSnapshotAsync(string[] computedStyles)
        {
            return await CommandAsync("captureSnapshot", 
                 new KeyValuePair<string, object>("computedStyles", computedStyles)
                 );
        }
    }
}
