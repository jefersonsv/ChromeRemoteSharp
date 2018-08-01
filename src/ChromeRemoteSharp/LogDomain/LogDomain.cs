using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.LogDomain
{
    public partial class LogDomain : BaseDomain
    {
        /// <summary>
        /// Provides access to log entries.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal LogDomain(RawDriver rawDriver) : base(rawDriver, "Log") { }
    }
}
