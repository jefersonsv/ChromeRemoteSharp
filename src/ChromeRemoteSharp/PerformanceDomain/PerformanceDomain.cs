using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.PerformanceDomain
{
    public partial class PerformanceDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Performance"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal PerformanceDomain(RawDriver rawDriver) : base(rawDriver, "Performance") { }
    }
}
