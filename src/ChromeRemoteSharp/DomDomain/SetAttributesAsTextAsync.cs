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
        /// Sets attributes on element with given id. This method is useful when user edits some existing attribute value and types in several attribute name/value pairs.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-setAttributesAsText"/>
        /// </summary>
        /// <param name="nodeId">Id of the element to set attributes for.</param>
        /// <param name="text">Text with a number of attributes. Will parse this text using HTML parser.</param>
        /// <param name="name">Attribute name to replace with new attributes derived from text in case text parsed successfully.</param>
        /// <returns></returns>
        public async Task<JObject> SetAttributesAsTextAsync(int nodeId, string text, string name = null)
        {
            return await CommandAsync("setAttributesAsText", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("text", text), 
                 new KeyValuePair<string, object>("name", name)
                 );
        }
    }
}
