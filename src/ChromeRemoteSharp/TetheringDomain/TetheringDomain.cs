using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.TetheringDomain
{
    public partial class TetheringDomain : BaseDomain
    {
        /// <summary>
        /// The Tethering domain defines methods and events for browser port binding.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tethering"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal TetheringDomain(RawDriver rawDriver) : base(rawDriver, "Tethering") { }
    }
}
