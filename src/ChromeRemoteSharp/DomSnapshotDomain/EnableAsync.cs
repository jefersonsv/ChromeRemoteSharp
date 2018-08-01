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
        /// Enables DOM snapshot agent for the given page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomSnapshot#enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
