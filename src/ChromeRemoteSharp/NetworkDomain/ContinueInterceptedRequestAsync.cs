using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Response to Network.requestIntercepted which either modifies the request to continue with any modifications, or blocks it, or completes it with the provided response bytes. If a network fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted event will be sent with the same InterceptionId.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-continueInterceptedRequest"/>
        /// </summary>
        /// <param name="interceptionId"></param>
        /// <param name="errorReason">If set this causes the request to fail with the given reason. Passing `Aborted` for requests marked with `isNavigationRequest` also cancels the navigation. Must not be set in response to an authChallenge.</param>
        /// <param name="rawResponse">If set the requests completes using with the provided base64 encoded raw response, including HTTP status line and headers etc... Must not be set in response to an authChallenge.</param>
        /// <param name="url">If set the request url will be modified in a way that's not observable by page. Must not be set in response to an authChallenge.</param>
        /// <param name="method">If set this allows the request method to be overridden. Must not be set in response to an authChallenge.</param>
        /// <param name="postData">If set this allows postData to be set. Must not be set in response to an authChallenge.</param>
        /// <param name="headers">If set this allows the request headers to be changed. Must not be set in response to an authChallenge.</param>
        /// <param name="authChallengeResponse">Response to a requestIntercepted with an authChallenge. Must not be set otherwise.</param>
        /// <returns></returns>
        public async Task<JObject> ContinueInterceptedRequestAsync(string interceptionId, string errorReason = null, string rawResponse = null, string url = null, string method = null, string postData = null, string headers = null, string authChallengeResponse = null)
        {
            return await CommandAsync("continueInterceptedRequest", 
                 new KeyValuePair<string, object>("interceptionId", interceptionId), 
                 new KeyValuePair<string, object>("errorReason", errorReason), 
                 new KeyValuePair<string, object>("rawResponse", rawResponse), 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("method", method), 
                 new KeyValuePair<string, object>("postData", postData), 
                 new KeyValuePair<string, object>("headers", headers), 
                 new KeyValuePair<string, object>("authChallengeResponse", authChallengeResponse)
                 );
        }
    }
}
