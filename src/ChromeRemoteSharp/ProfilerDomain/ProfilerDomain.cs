using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.ProfilerDomain
{
    public partial class ProfilerDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal ProfilerDomain(RawDriver rawDriver) : base(rawDriver, "Profiler") { }
    }
}
