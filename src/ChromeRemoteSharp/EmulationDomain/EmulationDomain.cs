using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain : BaseDomain
    {
        /// <summary>
        /// This domain emulates different environments for the page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal EmulationDomain(RawDriver rawDriver) : base(rawDriver, "Emulation") { }
    }
}
