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
        /// Removes attribute with given name from an element with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-removeAttribute"/>
        /// </summary>
        /// <param name="nodeId">Id of the element to remove attribute from.</param>
        /// <param name="name">Name of the attribute to remove.</param>
        /// <returns></returns>
        public async Task<JObject> RemoveAttributeAsync(int nodeId, string name)
        {
            return await CommandAsync("removeAttribute", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("name", name)
                 );
        }
    }
}
