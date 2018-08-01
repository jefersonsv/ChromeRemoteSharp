using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.CacheStorageDomain
{
    public partial class CacheStorageDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal CacheStorageDomain(RawDriver rawDriver) : base(rawDriver, "CacheStorage") { }
    }
}
