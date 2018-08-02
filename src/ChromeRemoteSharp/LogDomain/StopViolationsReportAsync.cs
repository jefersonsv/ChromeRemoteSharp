using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.LogDomain
{
    public partial class LogDomain
    {
        /// <summary>
        /// Stop violation reporting.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log#method-stopViolationsReport"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopViolationsReportAsync()
        {
            return await CommandAsync("stopViolationsReport");
        }
    }
}
