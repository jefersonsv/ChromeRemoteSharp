using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DeviceOrientationDomain
{
    public partial class DeviceOrientationDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DeviceOrientation"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DeviceOrientationDomain(RawDriver rawDriver) : base(rawDriver, "DeviceOrientation") { }
    }
}
