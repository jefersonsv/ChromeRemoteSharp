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
        /// Find a rule with the given active property for the given node and set the new value for this property
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#setEffectivePropertyValueForNode"/>
        /// </summary>
        /// <param name="nodeId">The element id for which to set property.</param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<JObject> SetEffectivePropertyValueForNodeAsync(string nodeId,string propertyName,string value)
        {
            return await CommandAsync("setEffectivePropertyValueForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("propertyName", propertyName), 
                 new KeyValuePair<string, object>("value", value)
                 );
        }
    }
}
