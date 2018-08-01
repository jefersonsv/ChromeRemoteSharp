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
        /// start violation reporting.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log#startViolationsReport"/>
        /// </summary>
        /// <param name="config">Configuration for violations.</param>
        /// <returns></returns>
        public async Task<JObject> StartViolationsReportAsync(string[] config)
        {
            return await CommandAsync("startViolationsReport", 
                 new KeyValuePair<string, object>("config", config)
                 );
        }
    }
}
