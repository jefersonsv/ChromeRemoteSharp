using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.SystemInfoDomain
{
    public partial class SystemInfoDomain : BaseDomain
    {
        /// <summary>
        /// The SystemInfo domain defines methods and events for querying low-level system information.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/SystemInfo"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal SystemInfoDomain(RawDriver rawDriver) : base(rawDriver, "SystemInfo") { }
    }
}
