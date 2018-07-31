using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        //    string Image compression format(defaults to png).jpeg, png
        //quality
        //    integer Compression quality from range[0..100] (jpeg only). 
        //clip
        //    Viewport Capture the screenshot of a given region only.
        //fromSurface
        //    boolean Capture the screenshot from the surface, rather than the view. Defaults to true.Experimental

        /// <summary>
        /// <seealso cref = "https://chromedevtools.github.io/devtools-protocol/tot/Page#method-captureScreenshot" />
        /// </ summary >
        /// < returns ></ returns >
        //public async Task<JObject> PageCaptureScreenshotAsync(string format, int quality, string clip, bool fromSurface)
        public async Task<JObject> CaptureScreenshotAsync()
        {
            return await CommandAsync("captureScreenshot");
        }
    }
}
