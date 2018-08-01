using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#handleJavaScriptDialog"/>
        /// </summary>
        /// <param name="accept">Whether to accept or dismiss the dialog.</param>
        /// <param name="promptText">The text to enter into the dialog prompt before accepting. Used only if this is a prompt dialog.</param>
        /// <returns></returns>
        public async Task<JObject> HandleJavaScriptDialogAsync(bool accept,string promptText)
        {
            return await CommandAsync("handleJavaScriptDialog", 
                 new KeyValuePair<string, object>("accept", accept), 
                 new KeyValuePair<string, object>("promptText", promptText)
                 );
        }
    }
}
