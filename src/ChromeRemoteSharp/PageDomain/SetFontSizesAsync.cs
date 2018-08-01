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
        /// Set default font sizes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#setFontSizes"/>
        /// </summary>
        /// <param name="fontSizes">Specifies font sizes to set. If a font size is not specified, it won't be changed.</param>
        /// <returns></returns>
        public async Task<JObject> SetFontSizesAsync(string fontSizes)
        {
            return await CommandAsync("setFontSizes", 
                 new KeyValuePair<string, object>("fontSizes", fontSizes)
                 );
        }
    }
}
