using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain : BaseDomain
    {
        /// <summary>
        /// Supports additional targets discovery and allows to attach to them.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal TargetDomain(RawDriver rawDriver) : base(rawDriver, "Target") { }
    }
}
