using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DatabaseDomain
{
    public partial class DatabaseDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Database"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DatabaseDomain(RawDriver rawDriver) : base(rawDriver, "Database") { }
    }
}
