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
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height, window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media query results).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setDeviceMetricsOverride"/>
        /// </summary>
        /// <param name="width">Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.</param>
        /// <param name="height">Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.</param>
        /// <param name="deviceScaleFactor">Overriding device scale factor value. 0 disables the override.</param>
        /// <param name="mobile">Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text autosizing and more.</param>
        /// <param name="scale">Scale to apply to resulting view image.</param>
        /// <param name="screenWidth">Overriding screen width value in pixels (minimum 0, maximum 10000000).</param>
        /// <param name="screenHeight">Overriding screen height value in pixels (minimum 0, maximum 10000000).</param>
        /// <param name="positionX">Overriding view X position on screen in pixels (minimum 0, maximum 10000000).</param>
        /// <param name="positionY">Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).</param>
        /// <param name="dontSetVisibleSize">Do not set visible view size, rely upon explicit setVisibleSize call.</param>
        /// <param name="screenOrientation">Screen orientation override.</param>
        /// <param name="viewport">If set, the visible area of the page will be overridden to this viewport. This viewport change is not observed by the page, e.g. viewport-relative elements do not change positions.</param>
        /// <returns></returns>
        public async Task<JObject> SetDeviceMetricsOverrideAsync(string width,string height,int deviceScaleFactor,bool mobile,int? scale,string screenWidth,string screenHeight,string positionX,string positionY,bool? dontSetVisibleSize,string screenOrientation,string viewport)
        {
            return await CommandAsync("setDeviceMetricsOverride", 
                 new KeyValuePair<string, object>("width", width), 
                 new KeyValuePair<string, object>("height", height), 
                 new KeyValuePair<string, object>("deviceScaleFactor", deviceScaleFactor), 
                 new KeyValuePair<string, object>("mobile", mobile), 
                 new KeyValuePair<string, object>("scale", scale), 
                 new KeyValuePair<string, object>("screenWidth", screenWidth), 
                 new KeyValuePair<string, object>("screenHeight", screenHeight), 
                 new KeyValuePair<string, object>("positionX", positionX), 
                 new KeyValuePair<string, object>("positionY", positionY), 
                 new KeyValuePair<string, object>("dontSetVisibleSize", dontSetVisibleSize), 
                 new KeyValuePair<string, object>("screenOrientation", screenOrientation), 
                 new KeyValuePair<string, object>("viewport", viewport)
                 );
        }
    }
}
