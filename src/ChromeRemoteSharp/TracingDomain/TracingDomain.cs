using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.TracingDomain
{
    public partial class TracingDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal TracingDomain(RawDriver rawDriver) : base(rawDriver, "Tracing") { }
    }
}
