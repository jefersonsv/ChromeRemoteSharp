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
        /// Sets the timing of an animation node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#setTiming"/>
        /// </summary>
        /// <param name="animationId">Animation id.</param>
        /// <param name="duration">Duration of the animation.</param>
        /// <param name="delay">Delay of the animation.</param>
        /// <returns></returns>
        public async Task<JObject> SetTimingAsync(string animationId,int duration,int delay)
        {
            return await CommandAsync("setTiming", 
                 new KeyValuePair<string, object>("animationId", animationId), 
                 new KeyValuePair<string, object>("duration", duration), 
                 new KeyValuePair<string, object>("delay", delay)
                 );
        }
    }
}
