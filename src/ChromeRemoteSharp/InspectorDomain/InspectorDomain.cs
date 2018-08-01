using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.InspectorDomain
{
    public partial class InspectorDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Inspector"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal InspectorDomain(RawDriver rawDriver) : base(rawDriver, "Inspector") { }
    }
}
