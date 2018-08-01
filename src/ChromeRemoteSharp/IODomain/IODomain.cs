using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.IODomain
{
    public partial class IODomain : BaseDomain
    {
        /// <summary>
        /// Input/Output operations for streams produced by DevTools.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IO"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal IODomain(RawDriver rawDriver) : base(rawDriver, "IO") { }
    }
}
