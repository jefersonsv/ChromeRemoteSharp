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
        /// Highlights given rectangle.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#highlightRect"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> HighlightRectAsync()
        {
            return await CommandAsync("highlightRect");
        }
    }
}
