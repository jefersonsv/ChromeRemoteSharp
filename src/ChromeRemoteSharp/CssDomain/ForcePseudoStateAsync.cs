using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#forcePseudoState"/>
        /// </summary>
        /// <param name="nodeId">The element id for which to force the pseudo state.</param>
        /// <param name="forcedPseudoClasses">Element pseudo classes to force when computing the element's style.</param>
        /// <returns></returns>
        public async Task<JObject> ForcePseudoStateAsync(string nodeId,string[] forcedPseudoClasses)
        {
            return await CommandAsync("forcePseudoState", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("forcedPseudoClasses", forcedPseudoClasses)
                 );
        }
    }
}
