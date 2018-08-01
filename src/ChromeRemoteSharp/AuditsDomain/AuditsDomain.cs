using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.AuditsDomain
{
    public partial class AuditsDomain : Domain
    {
        /// <summary>
        /// Audits domain allows investigation of page violations and possible improvements.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Audits"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal AuditsDomain(RawDriver rawDriver) : base(rawDriver, "Audits") { }
    }
}
