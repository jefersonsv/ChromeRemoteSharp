using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.ApplicationCacheDomain
{
    public partial class ApplicationCacheDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ApplicationCache"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal ApplicationCacheDomain(RawDriver rawDriver) : base(rawDriver, "ApplicationCache") { }
    }
}
