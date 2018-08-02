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
        /// Navigates current page to the given history entry.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-navigateToHistoryEntry"/>
        /// </summary>
        /// <param name="entryId">Unique id of the entry to navigate to.</param>
        /// <returns></returns>
        public async Task<JObject> NavigateToHistoryEntryAsync(string entryId)
        {
            return await CommandAsync("navigateToHistoryEntry", 
                 new KeyValuePair<string, object>("entryId", entryId)
                 );
        }
    }
}
