using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.ConsoleDomain
{
    public partial class ConsoleDomain : BaseDomain
    {
        /// <summary>
        /// This domain is deprecated - use Runtime or Log instead.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Console"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal ConsoleDomain(RawDriver rawDriver) : base(rawDriver, "Console") { }
    }
}
