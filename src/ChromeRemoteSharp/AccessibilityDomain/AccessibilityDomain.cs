using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.AccessibilityDomain
{
    public partial class AccessibilityDomain : Domain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Accessibility"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal AccessibilityDomain(RawDriver rawDriver) : base(rawDriver, "Accessibility") { }
    }
}
