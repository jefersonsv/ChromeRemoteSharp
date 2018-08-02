using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// Modifies the rule selector.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-setRuleSelector"/>
        /// </summary>
        /// <param name="styleSheetId"></param>
        /// <param name="range"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public async Task<JObject> SetRuleSelectorAsync(string styleSheetId, string range, string selector)
        {
            return await CommandAsync("setRuleSelector", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId), 
                 new KeyValuePair<string, object>("range", range), 
                 new KeyValuePair<string, object>("selector", selector)
                 );
        }
    }
}
