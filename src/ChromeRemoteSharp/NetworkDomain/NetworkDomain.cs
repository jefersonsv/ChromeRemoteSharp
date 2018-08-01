using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain : BaseDomain
    {
        /// <summary>
        /// Network domain allows tracking network activities of the page. It exposes information about http, file, data and other requests and responses, their headers, bodies, timing, etc.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal NetworkDomain(RawDriver rawDriver) : base(rawDriver, "Network") { }
    }
}
