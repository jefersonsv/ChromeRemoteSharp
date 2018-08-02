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
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-queryObjects"/>
        /// </summary>
        /// <param name="prototypeObjectId">Identifier of the prototype to return objects for.</param>
        /// <param name="objectGroup">Symbolic group name that can be used to release the results.</param>
        /// <returns></returns>
        public async Task<JObject> QueryObjectsAsync(string prototypeObjectId, string objectGroup = null)
        {
            return await CommandAsync("queryObjects", 
                 new KeyValuePair<string, object>("prototypeObjectId", prototypeObjectId), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup)
                 );
        }
    }
}
