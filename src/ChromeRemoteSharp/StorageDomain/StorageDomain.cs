using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.StorageDomain
{
    public partial class StorageDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Storage"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal StorageDomain(RawDriver rawDriver) : base(rawDriver, "Storage") { }
    }
}
