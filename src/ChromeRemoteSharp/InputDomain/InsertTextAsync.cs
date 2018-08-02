using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.InputDomain
{
    public partial class InputDomain
    {
        /// <summary>
        /// This method emulates inserting text that doesn't come from a key press, for example an emoji keyboard or an IME.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#method-insertText"/>
        /// </summary>
        /// <param name="text">The text to insert.</param>
        /// <returns></returns>
        public async Task<JObject> InsertTextAsync(string text)
        {
            return await CommandAsync("insertText", 
                 new KeyValuePair<string, object>("text", text)
                 );
        }
    }
}
