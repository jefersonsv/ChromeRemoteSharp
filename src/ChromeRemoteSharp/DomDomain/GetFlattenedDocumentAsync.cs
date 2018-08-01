using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Returns the root DOM node (and optionally the subtree) to the caller.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#getFlattenedDocument"/>
        /// </summary>
        /// <param name="depth">The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.</param>
        /// <param name="pierce">Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false).</param>
        /// <returns></returns>
        public async Task<JObject> GetFlattenedDocumentAsync(string depth,bool? pierce)
        {
            return await CommandAsync("getFlattenedDocument", 
                 new KeyValuePair<string, object>("depth", depth), 
                 new KeyValuePair<string, object>("pierce", pierce)
                 );
        }
    }
}
