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
        /// Obtain list of rules that became used since last call to this method (or since start of coverage instrumentation)
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#takeCoverageDelta"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> TakeCoverageDeltaAsync()
        {
            return await CommandAsync("takeCoverageDelta");
        }
    }
}
