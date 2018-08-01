using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.MemoryDomain
{
    public partial class MemoryDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal MemoryDomain(RawDriver rawDriver) : base(rawDriver, "Memory") { }
    }
}
