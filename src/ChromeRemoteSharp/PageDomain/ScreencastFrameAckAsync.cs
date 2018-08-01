using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Acknowledges that a screencast frame has been received by the frontend.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#screencastFrameAck"/>
        /// </summary>
        /// <param name="sessionId">Frame number.</param>
        /// <returns></returns>
        public async Task<JObject> ScreencastFrameAckAsync(string sessionId)
        {
            return await CommandAsync("screencastFrameAck", 
                 new KeyValuePair<string, object>("sessionId", sessionId)
                 );
        }
    }
}
