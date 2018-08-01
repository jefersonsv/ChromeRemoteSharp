using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomStorageDomain
{
    public partial class DomStorageDomain : BaseDomain
    {
        /// <summary>
        /// Query and modify DOM storage.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomStorage"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DomStorageDomain(RawDriver rawDriver) : base(rawDriver, "DOMStorage") { }
    }
}
