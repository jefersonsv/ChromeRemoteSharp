using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.ServiceWorkerDomain
{
    public partial class ServiceWorkerDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ServiceWorker"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal ServiceWorkerDomain(RawDriver rawDriver) : base(rawDriver, "ServiceWorker") { }
    }
}
