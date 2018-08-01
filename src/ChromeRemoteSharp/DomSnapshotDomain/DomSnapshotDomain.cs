using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomSnapshotDomain
{
    public partial class DomSnapshotDomain : BaseDomain
    {
        /// <summary>
        /// This domain facilitates obtaining document snapshots with DOM, layout, and style information.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomSnapshot"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DomSnapshotDomain(RawDriver rawDriver) : base(rawDriver, "DOMSnapshot") { }
    }
}
