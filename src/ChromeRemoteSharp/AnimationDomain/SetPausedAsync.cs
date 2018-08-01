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
        /// Sets the paused state of a set of animations.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#setPaused"/>
        /// </summary>
        /// <param name="animations">Animations to set the pause state of.</param>
        /// <param name="paused">Paused state to set to.</param>
        /// <returns></returns>
        public async Task<JObject> SetPausedAsync(string[] animations,bool paused)
        {
            return await CommandAsync("setPaused", 
                 new KeyValuePair<string, object>("animations", animations), 
                 new KeyValuePair<string, object>("paused", paused)
                 );
        }
    }
}
