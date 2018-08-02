using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Sets attribute for an element with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-setAttributeValue"/>
        /// </summary>
        /// <param name="nodeId">Id of the element to set attribute for.</param>
        /// <param name="name">Attribute name.</param>
        /// <param name="value">Attribute value.</param>
        /// <returns></returns>
        public async Task<JObject> SetAttributeValueAsync(int nodeId, string name, string value)
        {
            return await CommandAsync("setAttributeValue", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("name", name), 
                 new KeyValuePair<string, object>("value", value)
                 );
        }
    }
}
