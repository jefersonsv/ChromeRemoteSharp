using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.HeapProfilerDomain
{
    public partial class HeapProfilerDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal HeapProfilerDomain(RawDriver rawDriver) : base(rawDriver, "HeapProfiler") { }
    }
}
