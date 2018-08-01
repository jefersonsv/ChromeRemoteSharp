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
        /// Resizes the frame/viewport of the page. Note that this does not affect the frame's container (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported on Android.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setVisibleSize"/>
        /// </summary>
        /// <param name="width">Frame width (DIP).</param>
        /// <param name="height">Frame height (DIP).</param>
        /// <returns></returns>
        public async Task<JObject> SetVisibleSizeAsync(string width,string height)
        {
            return await CommandAsync("setVisibleSize", 
                 new KeyValuePair<string, object>("width", width), 
                 new KeyValuePair<string, object>("height", height)
                 );
        }
    }
}
