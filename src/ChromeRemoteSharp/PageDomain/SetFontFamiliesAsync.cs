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
        /// Set generic font families.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setFontFamilies"/>
        /// </summary>
        /// <param name="fontFamilies">Specifies font families to set. If a font family is not specified, it won't be changed.</param>
        /// <returns></returns>
        public async Task<JObject> SetFontFamiliesAsync(string fontFamilies)
        {
            return await CommandAsync("setFontFamilies", 
                 new KeyValuePair<string, object>("fontFamilies", fontFamilies)
                 );
        }
    }
}
