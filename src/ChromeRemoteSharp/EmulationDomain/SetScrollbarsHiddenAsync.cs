using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setScrollbarsHidden"/>
        /// </summary>
        /// <param name="hidden">Whether scrollbars should be always hidden.</param>
        /// <returns></returns>
        public async Task<JObject> SetScrollbarsHiddenAsync(bool hidden)
        {
            return await CommandAsync("setScrollbarsHidden", 
                 new KeyValuePair<string, object>("hidden", hidden)
                 );
        }
    }
}
