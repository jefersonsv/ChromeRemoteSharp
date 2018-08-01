using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TracingDomain
{
    public partial class TracingDomain
    {
        /// <summary>
        /// Start trace events collection.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing#start"/>
        /// </summary>
        /// <param name="categories">Category/tag filter</param>
        /// <param name="options">Tracing options</param>
        /// <param name="bufferUsageReportingInterval">If set, the agent will issue bufferUsage events at this interval, specified in milliseconds</param>
        /// <param name="transferMode">Whether to report trace events as series of dataCollected events or to save trace to a stream (defaults to `ReportEvents`).</param>
        /// <param name="streamCompression">Compression format to use. This only applies when using `ReturnAsStream` transfer mode (defaults to `none`)</param>
        /// <param name="traceConfig"></param>
        /// <returns></returns>
        public async Task<JObject> StartAsync(string categories,string options,int? bufferUsageReportingInterval,string transferMode,string streamCompression,string traceConfig)
        {
            return await CommandAsync("start", 
                 new KeyValuePair<string, object>("categories", categories), 
                 new KeyValuePair<string, object>("options", options), 
                 new KeyValuePair<string, object>("bufferUsageReportingInterval", bufferUsageReportingInterval), 
                 new KeyValuePair<string, object>("transferMode", transferMode), 
                 new KeyValuePair<string, object>("streamCompression", streamCompression), 
                 new KeyValuePair<string, object>("traceConfig", traceConfig)
                 );
        }
    }
}
