using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#setMaxCallStackSizeToCapture"/>
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<JObject> SetMaxCallStackSizeToCaptureAsync(string size)
        {
            return await CommandAsync("setMaxCallStackSizeToCapture", 
                 new KeyValuePair<string, object>("size", size)
                 );
        }
    }
}
