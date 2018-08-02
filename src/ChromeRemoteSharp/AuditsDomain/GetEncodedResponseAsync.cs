using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AuditsDomain
{
    public partial class AuditsDomain
    {
        /// <summary>
        /// Returns the response body and size if it were re-encoded with the specified settings. Only applies to images.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Audits#method-getEncodedResponse"/>
        /// </summary>
        /// <param name="requestId">Identifier of the network request to get content for.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <param name="quality">The quality of the encoding (0-1). (defaults to 1)</param>
        /// <param name="sizeOnly">Whether to only return the size information (defaults to false).</param>
        /// <returns></returns>
        public async Task<JObject> GetEncodedResponseAsync(string requestId, string encoding, int? quality = null, bool? sizeOnly = null)
        {
            return await CommandAsync("getEncodedResponse", 
                 new KeyValuePair<string, object>("requestId", requestId), 
                 new KeyValuePair<string, object>("encoding", encoding), 
                 new KeyValuePair<string, object>("quality", quality), 
                 new KeyValuePair<string, object>("sizeOnly", sizeOnly)
                 );
        }
    }
}
