using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain
    {
        /// <summary>
        /// Edits JavaScript source live.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setScriptSource"/>
        /// </summary>
        /// <param name="scriptId">Id of the script to edit.</param>
        /// <param name="scriptSource">New content of the script.</param>
        /// <param name="dryRun">If true the change will not actually be applied. Dry run may be used to get result description without actually modifying the code.</param>
        /// <returns></returns>
        public async Task<JObject> SetScriptSourceAsync(string scriptId, string scriptSource, bool? dryRun = null)
        {
            return await CommandAsync("setScriptSource", 
                 new KeyValuePair<string, object>("scriptId", scriptId), 
                 new KeyValuePair<string, object>("scriptSource", scriptSource), 
                 new KeyValuePair<string, object>("dryRun", dryRun)
                 );
        }
    }
}
