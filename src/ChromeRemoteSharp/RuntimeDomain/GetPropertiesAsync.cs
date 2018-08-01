using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// Returns properties of a given object. Object group of the result is inherited from the target object.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#getProperties"/>
        /// </summary>
        /// <param name="objectId">Identifier of the object to return properties for.</param>
        /// <param name="ownProperties">If true, returns properties belonging only to the element itself, not to its prototype chain.</param>
        /// <param name="accessorPropertiesOnly">If true, returns accessor properties (with getter/setter) only; internal properties are not returned either.</param>
        /// <param name="generatePreview">Whether preview should be generated for the results.</param>
        /// <returns></returns>
        public async Task<JObject> GetPropertiesAsync(string objectId,bool? ownProperties,bool? accessorPropertiesOnly,bool? generatePreview)
        {
            return await CommandAsync("getProperties", 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("ownProperties", ownProperties), 
                 new KeyValuePair<string, object>("accessorPropertiesOnly", accessorPropertiesOnly), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview)
                 );
        }
    }
}
