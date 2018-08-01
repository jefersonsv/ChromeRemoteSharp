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
        /// Highlights DOM node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#highlightNode"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> HighlightNodeAsync()
        {
            return await CommandAsync("highlightNode");
        }
    }
}
