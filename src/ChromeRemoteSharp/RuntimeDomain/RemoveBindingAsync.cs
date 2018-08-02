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
        /// This method does not remove binding function from global object but unsubscribes current runtime agent from Runtime.bindingCalled notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-removeBinding"/>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<JObject> RemoveBindingAsync(string name)
        {
            return await CommandAsync("removeBinding", 
                 new KeyValuePair<string, object>("name", name)
                 );
        }
    }
}
