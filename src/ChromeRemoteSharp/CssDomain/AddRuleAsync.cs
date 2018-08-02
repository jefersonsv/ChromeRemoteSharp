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
        /// Inserts a new rule with the given `ruleText` in a stylesheet with given `styleSheetId`, at the position specified by `location`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-addRule"/>
        /// </summary>
        /// <param name="styleSheetId">The css style sheet identifier where a new rule should be inserted.</param>
        /// <param name="ruleText">The text of a new rule.</param>
        /// <param name="location">Text position of a new rule in the target style sheet.</param>
        /// <returns></returns>
        public async Task<JObject> AddRuleAsync(string styleSheetId, string ruleText, string location)
        {
            return await CommandAsync("addRule", 
                 new KeyValuePair<string, object>("styleSheetId", styleSheetId), 
                 new KeyValuePair<string, object>("ruleText", ruleText), 
                 new KeyValuePair<string, object>("location", location)
                 );
        }
    }
}
