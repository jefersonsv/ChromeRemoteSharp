using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.HeadlessExperimentalDomain
{
    public partial class HeadlessExperimentalDomain
    {
        /// <summary>
        /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a screenshot from the resulting frame. Requires that the target was created with enabled BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also https://goo.gl/3zHXhB for more background.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeadlessExperimental#beginFrame"/>
        /// </summary>
        /// <param name="frameTimeTicks">Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set, the current time will be used.</param>
        /// <param name="interval">The interval between BeginFrames that is reported to the compositor, in milliseconds. Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.</param>
        /// <param name="noDisplayUpdates">Whether updates should not be committed and drawn onto the display. False by default. If true, only side effects of the BeginFrame will be run, such as layout and animations, but any visual updates may not be visible on the display or in screenshots.</param>
        /// <param name="screenshot">If set, a screenshot of the frame will be captured and returned in the response. Otherwise, no screenshot will be captured. Note that capturing a screenshot can fail, for example, during renderer initialization. In such a case, no screenshot data will be returned.</param>
        /// <returns></returns>
        public async Task<JObject> BeginFrameAsync(int? frameTimeTicks,int? interval,bool? noDisplayUpdates,string screenshot)
        {
            return await CommandAsync("beginFrame", 
                 new KeyValuePair<string, object>("frameTimeTicks", frameTimeTicks), 
                 new KeyValuePair<string, object>("interval", interval), 
                 new KeyValuePair<string, object>("noDisplayUpdates", noDisplayUpdates), 
                 new KeyValuePair<string, object>("screenshot", screenshot)
                 );
        }
    }
}
