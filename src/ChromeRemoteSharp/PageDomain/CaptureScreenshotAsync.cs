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
        /// Capture page screenshot.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-captureScreenshot"/>
        /// </summary>
        /// <param name="format">Image compression format (defaults to png).</param>
        /// <param name="quality">Compression quality from range [0..100] (jpeg only).</param>
        /// <param name="clip">Capture the screenshot of a given region only.</param>
        /// <param name="fromSurface">Capture the screenshot from the surface, rather than the view. Defaults to true.</param>
        /// <returns></returns>
        public async Task<JObject> CaptureScreenshotAsync(string format = null, string quality = null, string clip = null, bool? fromSurface = null)
        {
            return await CommandAsync("captureScreenshot", 
                 new KeyValuePair<string, object>("format", format), 
                 new KeyValuePair<string, object>("quality", quality), 
                 new KeyValuePair<string, object>("clip", clip), 
                 new KeyValuePair<string, object>("fromSurface", fromSurface)
                 );
        }
    }
}
