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
        /// Marks last undoable state.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#markUndoableState"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> MarkUndoableStateAsync()
        {
            return await CommandAsync("markUndoableState");
        }
    }
}
