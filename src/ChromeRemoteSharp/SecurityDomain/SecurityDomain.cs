using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.SecurityDomain
{
    public partial class SecurityDomain : BaseDomain
    {
        /// <summary>
        /// Security
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal SecurityDomain(RawDriver rawDriver) : base(rawDriver, "Security") { }
    }
}
