using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AnimationDomain
{
    public partial class AnimationDomain
    {
        /// <summary>
        /// Returns the current time of the an animation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#getCurrentTime"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetCurrentTimeAsync()
        {
            return await CommandAsync("getCurrentTime");
        }
    }
}
