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
        /// Starts sending each frame using the `screencastFrame` event.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#startScreencast"/>
        /// </summary>
        /// <param name="format">Image compression format.</param>
        /// <param name="quality">Compression quality from range [0..100].</param>
        /// <param name="maxWidth">Maximum screenshot width.</param>
        /// <param name="maxHeight">Maximum screenshot height.</param>
        /// <param name="everyNthFrame">Send every n-th frame.</param>
        /// <returns></returns>
        public async Task<JObject> StartScreencastAsync(string format,string quality,string maxWidth,string maxHeight,string everyNthFrame)
        {
            return await CommandAsync("startScreencast", 
                 new KeyValuePair<string, object>("format", format), 
                 new KeyValuePair<string, object>("quality", quality), 
                 new KeyValuePair<string, object>("maxWidth", maxWidth), 
                 new KeyValuePair<string, object>("maxHeight", maxHeight), 
                 new KeyValuePair<string, object>("everyNthFrame", everyNthFrame)
                 );
        }
    }
}
