using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomDebuggerDomain
{
    public partial class DomDebuggerDomain : BaseDomain
    {
        /// <summary>
        /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript execution will stop on these operations as if there was a regular breakpoint set.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomDebugger"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DomDebuggerDomain(RawDriver rawDriver) : base(rawDriver, "DOMDebugger") { }
    }
}
