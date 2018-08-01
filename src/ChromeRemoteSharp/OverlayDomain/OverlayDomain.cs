using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain : BaseDomain
    {
        /// <summary>
        /// This domain provides various functionality related to drawing atop the inspected page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal OverlayDomain(RawDriver rawDriver) : base(rawDriver, "Overlay") { }
    }
}
