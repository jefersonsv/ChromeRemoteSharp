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
        /// If executionContextId is empty, adds binding with the given name on the global objects of all inspected contexts, including those created later, bindings survive reloads. If executionContextId is specified, adds binding only on global object of given execution context. Binding function takes exactly one argument, this argument should be string, in case of any other input, function throws an exception. Each binding function call produces Runtime.bindingCalled notification.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#addBinding"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="executionContextId"></param>
        /// <returns></returns>
        public async Task<JObject> AddBindingAsync(string name,string executionContextId)
        {
            return await CommandAsync("addBinding", 
                 new KeyValuePair<string, object>("name", name), 
                 new KeyValuePair<string, object>("executionContextId", executionContextId)
                 );
        }
    }
}
