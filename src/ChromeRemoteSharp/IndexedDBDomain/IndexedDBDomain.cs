using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.IndexedDBDomain
{
    public partial class IndexedDBDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal IndexedDBDomain(RawDriver rawDriver) : base(rawDriver, "IndexedDB") { }
    }
}
