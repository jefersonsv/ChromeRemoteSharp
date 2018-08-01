using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain : BaseDomain
    {
        /// <summary>
        /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing breakpoints, stepping through execution, exploring stack traces, etc.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DebuggerDomain(RawDriver rawDriver) : base(rawDriver, "Debugger") { }
    }
}
