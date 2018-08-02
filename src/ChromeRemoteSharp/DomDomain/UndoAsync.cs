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
        /// Undoes the last performed action.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-undo"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> UndoAsync()
        {
            return await CommandAsync("undo");
        }
    }
}
