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
        /// Re-does the last undone action.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-redo"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> RedoAsync()
        {
            return await CommandAsync("redo");
        }
    }
}
